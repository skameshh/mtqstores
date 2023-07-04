using mtqstores.DB;
using mtqstores.Gagues;
using mtqstores.Global;
using mtqstores.Users;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class FormAuditorList : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FormAuditorList()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //loading departments===
            ArrayList lst_depts = DBUtils.getAllGageBrand();
            for (int x = 0; x < lst_depts.Count; x++)
            {
                String dept = (String)lst_depts[x];
                cboBrand.Items.Add(dept);
            }

            //loading type===
            ArrayList lst_type = DBUtils.getAllGageRange();
            for (int x = 0; x < lst_type.Count; x++)
            {
                String item_type = (String)lst_type[x];
                cboRange.Items.Add(item_type);
            }

            //===swl===
            ArrayList lst_swl = DBUtils.getAllGageCalibMethod();
            for (int x = 0; x < lst_swl.Count; x++)
            {
                String swl = (String)lst_swl[x];
                cboCalibMethod.Items.Add(swl);
            }

            //
            //MYGlobal.doButtonEnabled(btnBorrowReturn, false); 
            //MYGlobal.doButtonEnabled(btnExpiringThisMonth, false);
            //MYGlobal.doButtonEnabled(btnUserMgmt, false);
        }




        //SELECT  `id`,  `gage_id`,  `gage_desc`,  `gage_brand`,  `gage_rance`,  `gage_slno`,  LEFT(`gage_calib_metho`, 256),  `tolerance`,  `calib_date`,  `calib_interval`,  `calb_interval_unit`,  `calib_due_date`,  `clib_agency`,  `calib_cert_no`,  `gage_location`,  `remarks`,  `comments`,  `master_gage_slno`,  `master_gage_cert_no`,  `master_gage_valid_date`,  `gage_status` FROM `ocstoolinventorymgmt`.`t_gagues` LIMIT 1000;
        //SHOW CREATE TABLE `ocstoolinventorymgmt`.`t_gagues`;
        private void loadDG()
        {
            String sql = "select id,  gage_id,  gage_desc,  gage_brand,  gage_rance,  gage_slno,  LEFT(gage_calib_metho, 256) as gage_calib_metho,  tolerance,  calib_date,  " +
                "             case      when   calb_interval_unit='Years' And  calib_interval=1 Then 12 ELSE  calib_interval  end AS  calib_interval,   calib_due_date,  clib_agency,  calib_cert_no,  gage_location  " +             
                " from t_gagues";


            //String sql = "select id,  gage_id,  gage_desc,  gage_brand,  gage_rance,  gage_slno,   tolerance,  calib_date,  " +
            //    " calib_interval,  calb_interval_unit,  calib_due_date,  clib_agency,  calib_cert_no,  gage_location,  remarks,  comments,  master_gage_slno,  " +
            //    " master_gage_cert_no,  master_gage_valid_date,  gage_status, avail_qty, qty " +
            //    " from t_gagues";


            String brand = cboBrand.Text;
            string range = cboRange.Text;
            string calibMethod = cboCalibMethod.Text;
            string tag_num = txtGaugeId.Text;
            string desc = txtDesc.Text;

            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            try
            {

                if (tag_num.Length > 0)
                {
                    tag_num = tag_num.Trim();
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and tag_no='" + tag_num + "'";
                    }
                    else
                    {
                        sql = sql + " where  tag_no='" + tag_num + "'";
                    }
                }

                if (desc.Length > 0)
                {
                    desc = desc.Trim();
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and description like '%" + desc + "%'";
                    }
                    else
                    {
                        sql = sql + " where  description like '%" + desc + "%'";
                    }
                }


                if (brand.Length > 0)
                {
                    brand = brand.Trim();
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and gage_brand='" + brand + "'";
                    }
                    else
                    {
                        sql = sql + " where  gage_brand='" + brand + "'";
                    }
                }

                if (range.Length > 0)
                {
                    range = range.Trim();
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and gage_rance='" + range + "'";
                    }
                    else
                    {
                        sql = sql + " where  gage_rance='" + range + "'";
                    }
                }

                if (calibMethod.Length > 0)
                {
                    calibMethod = calibMethod.Trim();
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and gage_calib_metho='" + calibMethod + "'";
                    }
                    else
                    {
                        sql = sql + " where  gage_calib_metho='" + calibMethod + "'";
                    }
                }

                sql = sql + " order by id desc";

                log.Info("Gauges sql " + sql);

                using (MySqlConnection conn = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd))
                        {
                            try
                            {
                                DataTable dt = new DataTable();
                                sqlDa.Fill(dt);
                                dataGridView1.DataSource = dt;
                                //dataGridView1.AutoGenerateColumns = false;
                                dataGridView1.Cursor = Cursors.Default;

                                int rowscount = dataGridView1.Rows.Count;
                                lblTotalRows.Text = "" + (rowscount - 1);
                                for (int i = 0; i < rowscount; i++)
                                {
                                    //cells_count
                                    int cells_count = dataGridView1.Rows[i].Cells.Count;


                                }

                            }
                            catch (Exception ee)
                            {
                                log.Error("Error in row " + ee.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                log.Error("Error " + ee.Message);
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            loadDG();
        }

        private void doSearchClear()
        {
            cboBrand.Text = "";
            cboCalibMethod.Text = "";
            cboRange.Text = "";
            txtDesc.Text = "";
            txtGaugeId.Text = "";

        }







        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void ExcelExport()
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void doRowClick(DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                /* int id = 0;
                 string dept = string.Empty;
                 string descption = string.Empty;
                 string type = string.Empty;
                 string tagnum = string.Empty;
                 string swl = string.Empty;
                 string length = string.Empty;
                 string remarks = string.Empty;*/

                GaguesDao dao = new GaguesDao();

                if (dgvRow.Cells["dgId"].Value != DBNull.Value)
                {
                    dao.Id = (int)dgvRow.Cells["dgId"].Value;
                }

                if (dgvRow.Cells["dggage_id"].Value != DBNull.Value)
                {
                    dao.GageId = (string)dgvRow.Cells["dggage_id"].Value;
                }


                if (dgvRow.Cells["dggage_desc"].Value != DBNull.Value)
                {
                    dao.GageDesc = (string)dgvRow.Cells["dggage_desc"].Value;
                }

                if (dgvRow.Cells["dggage_brand"].Value != DBNull.Value)
                {
                    dao.GageBrand = (string)dgvRow.Cells["dggage_brand"].Value;
                }

               
                if (dgvRow.Cells["dggage_rance"].Value != DBNull.Value)
                {
                    dao.GageRance = (string)dgvRow.Cells["dggage_rance"].Value;
                }

                if (dgvRow.Cells["dggage_slno"].Value != DBNull.Value)
                {
                    dao.GageSlNo = (string)dgvRow.Cells["dggage_slno"].Value;
                }

                if (dgvRow.Cells["dgcalib_date"].Value != DBNull.Value)
                {
                    try
                    {
                        MySqlDateTime my = (MySqlDateTime)dgvRow.Cells["dgcalib_date"].Value;
                        dao.CalibDate = my.GetDateTime();
                      //  dao.CalibDate = DateTime.Parse((string)dgvRow.Cells["dgcalib_date"].Value.ToString());

                    }
                    catch(Exception ee)
                    {
                        log.Error("doRowClick() EE " + ee.Message);
                    }
                }

                if (dgvRow.Cells["dgcalib_due_date"].Value != DBNull.Value)
                {
                    try {
                        MySqlDateTime my = (MySqlDateTime)dgvRow.Cells["dgcalib_due_date"].Value;
                        dao.CalibDueDate = my.GetDateTime();
                        //  dao.CalibDueDate = DateTime.Parse((string)dgvRow.Cells["dgcalib_due_date"].Value);
                    }
                    catch (Exception ee)
                    {
                        log.Error("doRowClick() EE " + ee.Message);
                    }
                }

                if (dgvRow.Cells["dgavail_qty"].Value != DBNull.Value)
                {
                    dao.AvailQty = (int)dgvRow.Cells["dgavail_qty"].Value;
                }

                //set gageid
                //txtEquipTag.Text = dao.GageId;


                if (MYGlobal.loggedInUserDao != null)
                {
                    if (MYGlobal.loggedInUserDao.Dept.Equals("Admin"))
                    {                                            

                        GaguesDao ndao = DBUtils.getGageForGageId(dao.Id, null);
                        //open add gage form
                        FormAddNewGagues frm = new FormAddNewGagues(ndao);
                        frm.ShowDialog();
                        //refresh again after insert or update
                        loadDG();

                    }
                }

               
            }
            catch (Exception ee)
            {
                log.Error("ee " + ee.Message);
            }

        }//

        //========= borrow return ===========

        private void doBorrowReturn()
        {
            //string equiptag = txtEquipTag.Text;
            //if (equiptag.Length < 5)
            //{
            //    MessageBox.Show("Please enter/scan correct GaguesDao Tag, Or Select from the table");
            //    return;
            //}

            //GaguesDao dao = DBUtils.getGagueForTagId(0, equiptag);
            //if (dao != null)
            //{
            //    FormGaguesBorrowReturn frm = new FormGaguesBorrowReturn(equiptag, dao);
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Sorry this GaguesDao tag cant find in the database");
            //    return;
            //}

        }

        //============= LOGIN ==============

        private void doInfoLogin()
        {
            //if (btnLogin.Text.Equals("Logout"))
            //{
            //    doLogout();
            //}
            //else
            //{
            //    doLogin();
            //}
        }


        private void doLogin()
        {
            //string userid = txtUserId.Text;
            //if (userid.Length < 5)
            //{
            //    MessageBox.Show("Please enter/scan correct user id");
            //    return;
            //}
            //UserDao dao = DBUtils.getUserByUserId(1, 0);
            //if (dao != null)
            //{

            //    doLoginSuccess(dao);
            //}
            //else
            //{
            //    MessageBox.Show("User not found " + userid);
            //    return;
            //}
        }

        private void doLoginSuccess(UserDao dao)
        {
            MYGlobal.loggedInUserDao = dao;
            MYGlobal.loggedInUser_Id = dao.UserId;
            //txtUserId.Enabled = false;
            //btnLogin.Text = "Logout";
            //MYGlobal.doButtonEnabled(btnBorrowReturn, true);
            //MYGlobal.doButtonEnabled(btnExpiringThisMonth, true);
            
            //only admin can do this
            //if (dao.Dept.Equals("Admin"))
            //{
            //    MYGlobal.doButtonEnabled(btnUserMgmt, true);
            //}
        }

        private void doLogout()
        {
            DialogResult res = MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                //btnLogin.Text = "Login";
                //txtUserId.Enabled = true;
                MYGlobal.loggedInUserDao = null;
                MYGlobal.loggedInUser_Id = 0;

                //MYGlobal.doButtonEnabled(btnBorrowReturn, false);
                //MYGlobal.doButtonEnabled(btnExpiringThisMonth, false);
                //MYGlobal.doButtonEnabled(btnUserMgmt, false);

                //txtUserId.Text = "";
            }
        }

        private void doAdd()
        {

            if (MYGlobal.loggedInUserDao != null)
            {
                if (MYGlobal.loggedInUserDao.Dept.Equals("Admin"))
                {
                    FormAddNewGagues frm = new FormAddNewGagues(null);
                    frm.ShowDialog();
                    //refresh again after insert or update
                    loadDG();
                }
                else
                {
                    MessageBox.Show("Only Admin can add/update and Delete records");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Login, Only Admin can add/update and Delete records");
                return;
            }
        }

        private void doLoadUsermgmt()
        {
            FormUserMgmt um = new FormUserMgmt();
            um.Show();
        }

        private void doBorrowReturnHistoryForm()
        {
            FormGaugeBorrowReturnHistory frm = new FormGaugeBorrowReturnHistory();
            frm.Show();
        }

        private void doOpenExpiring()
        {
            FormGagueExpiring frm = new FormGagueExpiring();
            frm.Show();
        }

        private void btnAllMaterialExport2Excel_Click(object sender, EventArgs e)
        {
             MYGlobal.export2Excel(dataGridView1, "AllEquipments");
           // ExcelExport();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            loadDG();
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            doSearchClear();
        }

        private void FormEquipmentsMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            FormMain frm = new FormMain();
            frm.Visible = true;
        }


        private void doTime()
        {
            //lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            doTime();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doRowClick(e);
        }

        private void FormGaguesMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            FormMain frm = new FormMain();
            frm.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            doInfoLogin();
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            doBorrowReturn();
        }

        private void pbAdd1_Click(object sender, EventArgs e)
        {
            doAdd();
        }

        private void btnExpiringThisMonth_Click(object sender, EventArgs e)
        {
            doOpenExpiring();
        }

        private void btnBorrowReturnHistory_Click(object sender, EventArgs e)
        {
            doBorrowReturnHistoryForm();
        }

        private void btnUserMgmt_Click(object sender, EventArgs e)
        {
            doLoadUsermgmt();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
