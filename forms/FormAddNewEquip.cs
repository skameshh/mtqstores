using mtqstores.DB;
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

namespace mtqstores.forms
{
    public partial class FormAddNewEquip : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private string action = "edit";
        private EquipmentDao dao = null;

        public FormAddNewEquip(EquipmentDao dao)
        {
            InitializeComponent();
            this.dao = dao;
            init();

            if (dao != null)
            {
                try
                {
                    lblMainTitle.Text = "Update / Delete Equipment";
                    txtTagNum.Enabled = false;
                    btnClear.Enabled = false;
                    btnDelete.Enabled = true;

                    action = "edit";


                    lblId.Text = dao.Id + "";
                    txtDesc.Text = dao.Description;
                    txtLength.Text = dao.Length;
                    txtRemarks.Text = dao.Remarks;
                    txtTagNum.Text = dao.TagNo;

                    cboDepts.Text = dao.Dept;
                    cboSwl.Text = dao.Swl;
                    cboType.Text = dao.Type;

                    //dtpExpDate.Value = dao.ExpDate;
                }
                catch (Exception ee)
                {
                    log.Error("Error " + ee.Message);
                }
            }
            else
            {
                //add new equip
                lblMainTitle.Text = "Add New Equipment";
                action = "add";
                btnDelete.Enabled = false;
            }
        }

        private void init()
        {
            //loading departments===
            ArrayList lst_depts = DBUtils.getAllEqupmentsDepts();
            for (int x = 0; x < lst_depts.Count; x++)
            {
                String dept = (String)lst_depts[x];
                cboDepts.Items.Add(dept);
            }

            //loading type===
            ArrayList lst_type = DBUtils.getAllEqupmentsType();
            for (int x = 0; x < lst_type.Count; x++)
            {
                String item_type = (String)lst_type[x];
                cboType.Items.Add(item_type);
            }

            //===swl===
            ArrayList lst_swl = DBUtils.getAllSWL();
            for (int x = 0; x < lst_swl.Count; x++)
            {
                String swl = (String)lst_swl[x];
                cboSwl.Items.Add(swl);
            }
        }

        private void doSave()
        {
            EquipmentDao dao = new EquipmentDao();
            dao.Remarks = txtRemarks.Text;
            dao.Length = txtLength.Text;
            dao.Description = txtDesc.Text;
            dao.Dept = cboDepts.Text;
            dao.TagNo = txtTagNum.Text;
            dao.Swl = cboSwl.Text;
            dao.Type = cboType.Text;
            dao.ExpDate = dtpExpDate.Value;

            if (action == "add")
            {
                bool bb = DBUtils.doAddEquipment(dao);
                if (bb)
                {
                    MessageBox.Show("Add success");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Add failed");
                }

            }
            else if (action == "edit")
            {
                dao.Id = Int32.Parse(lblId.Text);
              bool bb =  DBUtils.doUpdateEquipment(dao);
                if (bb)
                {
                    MessageBox.Show("Update success");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
        }

        private void doClear()
        {
            txtDesc.Text = "";
            txtLength.Text = "";
            txtRemarks.Text = "";
            txtTagNum.Text = "";

            cboDepts.Text = "";
            cboSwl.Text = "";
            cboType.Text = "";

        }

        private void doDelete()
        {
            DialogResult res = MessageBox.Show("Are you sure to delete, It will send email to the team ? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
               int id = Int32.Parse(lblId.Text);
                bool bb = DBUtils.doDeleteEquipment(id);
                if (bb)
                {
                    MessageBox.Show("Delete success");
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            doClear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            doDelete();
        }
    }
}
