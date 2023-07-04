using mtqstores.DB;
using mtqstores.Global;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtqstores.Gagues
{
    public partial class FormGaguesBorrowReturn : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string equipTagNum = string.Empty;
        private GaguesDao dao = null;

        public FormGaguesBorrowReturn(string equipTagNum, GaguesDao dao)
        {
            InitializeComponent();
            this.equipTagNum = equipTagNum;
            this.dao = dao;
            this.lblAvailQty.Text = dao.AvailQty + "";
            this.lblEquipTag.Text = dao.GageId;
            this.txtEquipDesc.Text = dao.GageDesc;
        }

        // Check how many qty available
        //Update master table for avail qty
        private void doSave()
        {

            if (rdoIn.Checked)
            {
                //doReturn
                doReturn();
            }
            else
            {
                //doBorrow
                doBorrow();
            }
        }


        private void doBorrow()
        {
            if (dao.AvailQty <= 0)
            {
                MessageBox.Show("Sorry no Gage availabe  to borrow");
                return;
            }
            if (cmdBStatus.SelectedIndex==-1)
            {
                MessageBox.Show("Select borrow status");
                return;
            }
            int req_qty = 0;
            try
            {
                req_qty = Int32.Parse(txtTransQty.Text);
                if (req_qty > dao.AvailQty)
                {
                    MessageBox.Show("Sorry only " + dao.AvailQty + " is available.");
                    return;
                }
            }
            catch (Exception ee)
            {
                log.Error("Error " + ee.Message);
                MessageBox.Show("Error " + ee.Message);
                return;
            }

            GagueTransHistoryDao edao = new GagueTransHistoryDao();
            edao.EquipTag = dao.GageId;
            edao.BorrowedBy = MYGlobal.loggedInUser_Id;
            edao.BorrowedOn = DateTime.Now;
            edao.BorrowComments = txtTransRemarks.Text;
            edao.Status = 0;
            //



            bool bb = DBUtils.doAddGaugeTransHistory(edao);
            if (bb)
            {
                MessageBox.Show("Borrow success ");
                int avail_qty = dao.AvailQty - req_qty;
                //update master db
                bool retb = DBUtils.doUpdateGagueAvailQty(dao.Id, avail_qty,cmdBStatus.Text);
            }
            else
            {
                MessageBox.Show("Borrow failed ");
            }

        }

        private void doReturn()
        {
            if (dao.AvailQty == dao.Qty)
            {
                MessageBox.Show("Sorry AvailQty=FixedQty , you cant return this item, Please do a borrow first.");
                return;
            }

            int req_qty = 0;
            try
            {
                req_qty = Int32.Parse(txtTransQty.Text);
                if (req_qty > dao.AvailQty)
                {
                    MessageBox.Show("Sorry only " + dao.AvailQty + " is available.");
                    return;
                }
            }
            catch (Exception ee)
            {
                log.Error("Error " + ee.Message);
                MessageBox.Show("Error " + ee.Message);
                return;
            }

            int avail_qty = dao.AvailQty + req_qty;
            if (avail_qty > dao.Qty)
            {
                MessageBox.Show("Sorry returning too much " + req_qty + " equipments, Please check..");
                return;
            }

            GagueTransHistoryDao edao = new GagueTransHistoryDao();
            edao.EquipTag = dao.GageId;
            edao.ReturnedBy = MYGlobal.loggedInUser_Id;
            edao.RequrnedOn = DateTime.Now;
            edao.ReturnedComments = txtTransRemarks.Text;
            edao.Status = 1;

            //if already got borrow just update it or create new record
            ArrayList alx = DBUtils.getAGagueTransHistory(edao.EquipTag);
            if (alx.Count > 0)
            {
                GagueTransHistoryDao ehdao = (GagueTransHistoryDao)alx[0];
                edao.Id = ehdao.Id;
                bool bbd = DBUtils.doUpdateGagueTransHistory(edao);
                //Update main table

                if (bbd)
                {
                    MessageBox.Show("Return success ");

                    //update master db
                    bool retb = DBUtils.doUpdateGagueAvailQty(dao.Id, avail_qty,"Retrun");
                }
                else
                {
                    MessageBox.Show("Return failed ");
                }
            }
            else
            {

                // existing borrow record not found
                //so create new return record
                bool bb = DBUtils.doAddGaugeTransHistory(edao);
                if (bb)
                {
                    MessageBox.Show("Borrow success ");
                    //update master db
                    bool retb = DBUtils.doUpdateGagueAvailQty(dao.Id, avail_qty, "Retrun");
                }
                else
                {
                    MessageBox.Show("Borrow failed ");
                }
            }
        }

        private void doClear()
        {
            txtTransQty.Text = "";
            txtTransRemarks.Text = "";
            cmdBStatus.Enabled = true;
            cmdBStatus.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doSave();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            doClear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void rdoIn_CheckedChanged(object sender, EventArgs e)
        {
            cmdBStatus.Enabled = false;
        }

        private void rdoOut_CheckedChanged(object sender, EventArgs e)
        {
            cmdBStatus.Enabled = true;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            doClear();
        }
    }
}
