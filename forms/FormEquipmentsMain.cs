
using mtqstores.DB;
using mtqstores.EmailNotifications;
using mtqstores.equipments;
using mtqstores.Global;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtqstores.forms
{
    public partial class FormEquipmentsMain : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";

        public FormEquipmentsMain()
        {
            InitializeComponent();
            init();

            dtpFromDate.Value = new DateTime(getYear(), 1,1);

            dtpToDate.Value = new DateTime(getYear(), 12, 31);
            //DateTime dtFrom = dtpFromDate.Value;
            //DateTime dtTo = dtpToDate.Value;
        }

       

        private void init()
        {
            //loading departments===
            ArrayList lst_depts = DBUtils.getAllEqupmentsDepts();
            for (int x = 0; x < lst_depts.Count; x++)
            {
                String dept = (String)lst_depts[x];
                cboDept.Items.Add(dept);
            }

            //loading type===
            ArrayList lst_type= DBUtils.getAllEqupmentsType();
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
                cboSWL.Items.Add(swl);
            }

            //===============
            MYGlobal. doButtonEnabled(btnLogin, true);
           MYGlobal. doButtonEnabled(btnBorrowReturn, false);
            MYGlobal.doButtonEnabled(btnExpiringThisMonth, false);
            MYGlobal.doButtonEnabled(btnUserMgmt, false);

            
        }

       


        private int getYear()
        {
            return Int32.Parse(DateTime.Now.ToString("yyyy"));
        }

        private void loadDG()
        {
            String sql = "select * from t_equipments";
            String dept = cboDept.Text;
            string type = cboType.Text;
            string swl = cboSWL.Text;
            string tag_num = txtTagNo.Text;
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


                if (dept.Length > 0)
                {
                    dept = dept.Trim();
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and dept='" + dept + "'";
                    }
                    else
                    {
                        sql = sql + " where  dept='" + dept + "'";
                    }
                }

                if (type.Length > 0)
                {
                    type = type.Trim();
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and type='" + type + "'";
                    }
                    else
                    {
                        sql = sql + " where  type='" + type + "'";
                    }
                }

                if (swl.Length > 0)
                {
                    swl = swl.Trim();
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and swl='" + swl + "'";
                    }
                    else
                    {
                        sql = sql + " where  swl='" + swl + "'";
                    }
                }

                //date
               DateTime dtFrom =   dtpFromDate.Value;
               DateTime dtTo = dtpToDate.Value;
                if (sql.Contains("where "))
                {
                    sql = sql + " and exp_date>='" + dtFrom.ToString("yyyy-MM-dd") + "' and exp_date<='"+ dtTo.ToString("yyyy-MM-dd") + "' ";
                }
                else
                {
                    sql = sql + " where  exp_date>='" + dtFrom.ToString("yyyy-MM-dd") + "' and exp_date<='" + dtTo.ToString("yyyy-MM-dd") + "' ";
                }


                //
                sql = sql + " order by id desc";
                log.Info("Sql = " + sql);
                using (MySqlConnection conn = new MySqlConnection(MYGlobal.getMySqlCString()))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataAdapter sqlDa = new MySqlDataAdapter(cmd))
                        {
                            
                                DataTable dt = new DataTable();
                                sqlDa.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.Cursor = Cursors.Default;

                                int rowscount = dataGridView1.Rows.Count;
                                lblTotalRows.Text = "" + (rowscount - 1);
                                for (int i = 0; i < rowscount-1; i++)
                                {
                                    //cells_count
                                    int cells_count = dataGridView1.Rows[i].Cells.Count;

                                    try
                                    {
                                        
                                        if (dataGridView1.Rows[i].Cells["dgexp_date"].Value != DBNull.Value || dataGridView1.Rows[i].Cells["dgexp_date"].Value!=null)
                                        {
                                            MySqlDateTime ss  = (MySqlDateTime)dataGridView1.Rows[i].Cells["dgexp_date"].Value;
                                           // log.Info("ss = " + ss);
                                            if (ss.Value != null)
                                            {
                                               
                                                DateTime dtx = Convert.ToDateTime(ss.Value);
                                              
                                                if (dtx < DateTime.Now)
                                                {
                                                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Salmon;
                                                }
                                            }
                                        }
                                       
                                    }catch(Exception ee)
                                    {
                                         log.Info("Error " + ee);
                                    }
                                }//for

                            
                        }
                    }
                }
            }
            catch(Exception ee)
            {
                log.Error("Error " + ee.Message);
            }
        }


        private void doCellFormatting(DataGridViewCellFormattingEventArgs e)
        {

            try
            {

              //  MySqlDateTime ss = (MySqlDateTime)dataGridView1.Rows[e.RowIndex].Cells["dgexp_date"].Value == null ?
        //  DateTime.MinValue : dataGridView1.Rows[e.RowIndex].Cells["dgexp_date"].Value;


                if (dataGridView1.Rows[e.RowIndex].Cells["dgexp_date"].Value != DBNull.Value || dataGridView1.Rows[e.RowIndex].Cells["dgexp_date"].Value != null)
                 //   if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["dgexp_date"].Value.ToString()))

                    {
                  //  var test = dataGridView1.Rows[e.RowIndex].Cells["dgexp_date"].Value.ToString();
                    MySqlDateTime ss = (MySqlDateTime)dataGridView1.Rows[e.RowIndex].Cells["dgexp_date"].Value;
                    // log.Info("ss = " + ss);
                    if (ss.Value != null)
                    {

                        DateTime dtx = Convert.ToDateTime(ss.Value);

                        if (dtx < DateTime.Now)
                        {
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
                        }
                    }
                }

            }
            catch (Exception ee)
            {
                 log.Info("Error " + ee);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            loadDG();
        }

        private void doSearchClear()
        {
            cboDept.Text = "";
            cboSWL.Text = "";
            cboType.Text = "";
            txtDesc.Text = "";
            txtTagNo.Text = "";

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

                EquipmentDao dao = new EquipmentDao();

                if (dgvRow.Cells["dgId"].Value != DBNull.Value)
                {
                    dao.Id = (int)dgvRow.Cells["dgId"].Value;
                }

                if (dgvRow.Cells["dgdept"].Value != DBNull.Value)
                {
                    dao.Dept = (string)dgvRow.Cells["dgdept"].Value;
                }

                if (dgvRow.Cells["dgdescription"].Value != DBNull.Value)
                {
                    dao.Description = (string)dgvRow.Cells["dgdescription"].Value;
                }

                if (dgvRow.Cells["dgtype"].Value != DBNull.Value)
                {
                    dao.Type = (string)dgvRow.Cells["dgtype"].Value;
                }

                if (dgvRow.Cells["dgtag_no"].Value != DBNull.Value)
                {
                    dao.TagNo = (string)dgvRow.Cells["dgtag_no"].Value;
                }

                if (dgvRow.Cells["dgswl"].Value != DBNull.Value)
                {
                    dao.Swl = (string)dgvRow.Cells["dgswl"].Value;
                }

                if (dgvRow.Cells["dglength"].Value != DBNull.Value)
                {
                    dao.Length = (string)dgvRow.Cells["dglength"].Value;
                }

                if (dgvRow.Cells["dgexp_date"].Value != DBNull.Value)
                {
                   // dao.ExpDate = DateTime.Parse((string)dgvRow.Cells["dgexp_date"].Value);
                }

                if (dgvRow.Cells["dgremarks"].Value != DBNull.Value)
                {
                    dao.Remarks = (string)dgvRow.Cells["dgremarks"].Value;
                }

                txtEquipTag.Text = dao.TagNo;


                if (MYGlobal.loggedInUserDao != null)
                {
                    if (MYGlobal.loggedInUserDao.Dept.Equals("Admin"))
                    {
                        FormAddNewEquip frm = new FormAddNewEquip(dao);
                        frm.ShowDialog();
                        //refresh again after insert or update
                        loadDG();
                    }
                }
               
 
            }
            catch(Exception ee)
            {
                log.Error("ee " + ee.Message);
            }

        }//
        private void doRowUpdate(DataGridViewCellEventArgs e)
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

                EquipmentDao dao = new EquipmentDao();

                if (dgvRow.Cells["dgId"].Value != DBNull.Value)
                {
                    dao.Id = (int)dgvRow.Cells["dgId"].Value;
                }

                if (dgvRow.Cells["dgdept"].Value != DBNull.Value)
                {
                    dao.Dept = (string)dgvRow.Cells["dgdept"].Value;
                }

                if (dgvRow.Cells["dgdescription"].Value != DBNull.Value)
                {
                    dao.Description = (string)dgvRow.Cells["dgdescription"].Value;
                }

                if (dgvRow.Cells["dgtype"].Value != DBNull.Value)
                {
                    dao.Type = (string)dgvRow.Cells["dgtype"].Value;
                }

                if (dgvRow.Cells["dgtag_no"].Value != DBNull.Value)
                {
                    dao.TagNo = (string)dgvRow.Cells["dgtag_no"].Value;
                }

                if (dgvRow.Cells["dgswl"].Value != DBNull.Value)
                {
                    dao.Swl = (string)dgvRow.Cells["dgswl"].Value;
                }

                if (dgvRow.Cells["dglength"].Value != DBNull.Value)
                {
                    dao.Length = (string)dgvRow.Cells["dglength"].Value;
                }

                if (dgvRow.Cells["dgexp_date"].Value != DBNull.Value)
                {
                    // dao.ExpDate = DateTime.Parse((string)dgvRow.Cells["dgexp_date"].Value);
                }

                if (dgvRow.Cells["dgremarks"].Value != DBNull.Value)
                {
                    dao.Remarks = (string)dgvRow.Cells["dgremarks"].Value;
                }

              
                bool bb = DBUtils.doUpdateEquipment(dao);
                if (bb)              
                    MessageBox.Show("Update success");                   
               
                else               
                    MessageBox.Show("Update failed");            



            }
            catch (Exception ee)
            {
                log.Error("ee " + ee.Message);
            }

        }//


        private void doAdd()
        {
            FormAddNewEquip frm = new FormAddNewEquip(null);
            frm.ShowDialog();
            //refresh again after insert or update
            loadDG();
        }

        private void btnAllMaterialExport2Excel_Click(object sender, EventArgs e)
        {
            MYGlobal.export2Excel(dataGridView1, "AllEquipments");
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


        private void doBorrowReturn()
        {
            string equiptag = txtEquipTag.Text;
            if (equiptag.Length < 5)
            {
                MessageBox.Show("Please enter/scan correct Equipment Tag, Or Select from the table");
                return;
            }

            EquipmentDao dao =  DBUtils.getEqupmentForTagId(0, equiptag);
            if (dao != null)
            {
                FormEquipBorrowReturn frm = new FormEquipBorrowReturn(equiptag, dao);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry this equipment tag cant find in the database");
                return;
            }
           
        }

        private void doLogin()
        {
            string userid = txtUserId.Text;
            if (userid.Length < 5)
            {
                MessageBox.Show("Please enter/scan correct user id");
                return;
            }
            UserDao dao = DBUtils.getUserByUserId(userid, 0);
            if (dao != null)
            {

                doLoginSuccess(  dao);
            }
            else
            {
                MessageBox.Show("User not found "+ userid);
                return;
            }
        }

        private void doLogout()
        {
            DialogResult res = MessageBox.Show("Are you sure to logout?","Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                btnLogin.Text = "Login";
                txtUserId.Enabled = true;
                MYGlobal.loggedInUserDao = null;
                MYGlobal.loggedInUser_Id = 0;

                MYGlobal.doButtonEnabled(btnBorrowReturn, false);
                MYGlobal.doButtonEnabled(btnExpiringThisMonth, false);
                MYGlobal.doButtonEnabled(btnUserMgmt, false);

                txtUserId.Text = "";
            }
        }

        private void doLoginSuccess(UserDao dao)
        {
            MYGlobal.loggedInUserDao = dao;
            MYGlobal.loggedInUser_Id = dao.UserId;
            txtUserId.Enabled = false;
            btnLogin.Text = "Logout";
            MYGlobal.doButtonEnabled(btnBorrowReturn, true);
            MYGlobal.doButtonEnabled(btnExpiringThisMonth, true);

            if (dao.Dept.Equals("Admin"))
            {
                MYGlobal.doButtonEnabled(btnUserMgmt, true);
            }
            
        }

        private void doTime()
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            doTime();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //doRowClick(e);
         

            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns.IndexOf(dataGridView1.Columns["btEdit"]))
            {
                //DataGridViewCell cell = dataGridView1["dggage_desc", e.RowIndex];
                //dataGridView1.CurrentCell = cell;
                doRowUpdate(e);
                dataGridView1.BeginEdit(true);
            }



        }

        private void pbAdd2_Click(object sender, EventArgs e)
        {
            doAdd();
        }

        private void pbAdd1_Click(object sender, EventArgs e)
        {
            doAdd();
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            doBorrowReturn();
        }

        private void doInfoLogin()
        {
            if (btnLogin.Text.Equals("Logout"))
            {
                doLogout();
            }
            else
            {
                doLogin();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            doInfoLogin();
        }

        private void btnExpiringThisMonth_Click(object sender, EventArgs e)
        {
            FormEquipExpiring frm = new FormEquipExpiring();
            frm.ShowDialog();
        }

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doInfoLogin();
            }
        }

        private void btnBorrowReturnHistory_Click(object sender, EventArgs e)
        {
            FormEquipBorrowReturnHistory frm = new FormEquipBorrowReturnHistory();
            frm.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.DataSource!=null)
           doCellFormatting(e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            doRowClick(e);
        }

        private void cmdImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {


                        MessageBox.Show("Please  wait..The process has  started.Cick OK  and  wait for  success message");
                        var fileName = openFileDialog1.FileName;
                        //  string fileName = Path.GetFileName(openFileDialog1.FileName);
                      //  var dt = ReadExcel(fileName);
                       // doSave(dt);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }

        //private DataTable ReadExcel(string fileName)
        //{
        //    WorkBook workbook = WorkBook.Load(fileName);
        //    //// Work with a single WorkSheet.
        //    ////you can pass static sheet name like Sheet1 to get that sheet
        //    WorkSheet sheet = workbook.GetWorkSheet("Sheet2");
        //    //You can also use workbook.DefaultWorkSheet to get default in case you want to get first sheet only
        //    // WorkSheet sheet = workbook.DefaultWorkSheet;
        //    //Convert the worksheet to System.Data.DataTable
        //    //Boolean parameter sets the first row as column names of your table.
        //    return sheet.ToDataTable(true);
        //}



        private void doSave(DataTable dt)
        {

            try
            {
                var loopcount = 0;
                foreach (DataRow rows in dt.Rows)
                {
                    EquipmentDao dao = new EquipmentDao();
                    dao.Remarks = rows["REMARKS"].ToString();
                    dao.Length = rows["length"].ToString();
                    dao.Description = rows["description"].ToString();
                    dao.Dept = rows["dept"].ToString();
                    dao.TagNo = rows["tag_no"].ToString();
                    dao.Swl = rows["Swl"].ToString();
                    dao.Type = rows["type"].ToString();
                    dao.ExpDate =DateTime.Parse( rows["exp_date"].ToString());
                    dao.Qty = int.Parse(rows["Qty"].ToString());
                    dao.AvailQty = int.Parse(rows["avail_qty"].ToString());
                    
                    var action = DBUtils.doCheckExsistEqupment(dao.TagNo);
                    if (!action)
                    {
                        bool bb = DBUtils.doAddImportEquipment(dao);
                        loopcount++;
                    }
                    else
                    {

                        bool bb = DBUtils.doUpdateImportEquipment(dao);
                        loopcount++;
                    }
                }

                if (loopcount > 0)
                {
                    loadDG();
                    MessageBox.Show("Data  import  is successful.");
                }
                    
                else
                    MessageBox.Show("Data  impport  is un-successful.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void cmdImportExcel_Click_1(object sender, EventArgs e)
        {
            DataTable dt;
            try
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {


                        MessageBox.Show("Please  wait..The process has  started.Cick OK  and  wait for  success message");
                        var fileName = openFileDialog1.FileName;
                        string extension = Path.GetExtension(fileName);
                        string conStr, sheetName;

                        conStr = string.Empty;

                        //var dt = ReadExcel(fileName, extension);
                        try
                        {

                            // string conStr, sheetName;
                            conStr = string.Empty;
                            switch (extension)
                            {

                                case ".xls": //Excel 97-03
                                    conStr = string.Format(Excel03ConString, fileName);
                                    break;

                                case ".xlsx": //Excel 07 to later
                                    conStr = string.Format(Excel07ConString, fileName);
                                    break;
                            }

                            using (OleDbConnection con = new OleDbConnection(conStr))
                            {
                                using (OleDbCommand cmd = new OleDbCommand())
                                {
                                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                                    {
                                        dt = new DataTable();
                                        cmd.CommandText = "SELECT * From [Sheet1$]";
                                        cmd.Connection = con;
                                        con.Open();
                                        oda.SelectCommand = cmd;
                                        oda.Fill(dt);
                                        con.Close();
                                    }
                                }
                            }
                            doSave(dt);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        //  string fileName = Path.GetFileName(openFileDialog1.FileName);
                        //   var dt = ReadExcel(fileName);
                       // doSave(dt);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }






      
        }

        private void btnEmailSend_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.ShowDialog();
        }
    }
}
