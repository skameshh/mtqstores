using mtqstores.DB;
using mtqstores.Global;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtqstores.Users
{
    public partial class FormUserMgmt : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string action = "add";
        public FormUserMgmt()
        {
            InitializeComponent();
            init();
        }


        private void init()
        {
            btnSave.Enabled = false;
            loadDG();
        }

        private void loadDG()
        {
            string sql = "select id, user_id, name, dept from t_user order by dept, name ";

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

        private void doSave()
        {
            UserDao dao = new UserDao();
            dao.UserId = Convert.ToInt32( txtUserId.Text);
            dao.Name = txtUserName.Text;
            dao.Dept = cboRole.Text;

            if (action.Equals("add"))
            {
                doAdd(dao);
            }
            else if (action.Equals("edit"))
            {
                dao.Id = Convert.ToInt32(lblId.Text);
                doUpdate(dao);
            }
        }


        private void doAdd(UserDao dao)
        {
         bool bb=   DBUtils.doAddUser(dao);
            if (bb)
            {
                btnSave.Enabled = false;
                MessageBox.Show("Add user success");

            }
            else
            {
                MessageBox.Show("Add user failed");
            }
        }

        private void doUpdate(UserDao dao)
        {
          bool bb=  DBUtils.doUpdateUser(dao);
            if (bb)
            {
                btnSave.Enabled = false;
                MessageBox.Show("Update user success");
                lblId.Text = "";
            }
            else
            {
                MessageBox.Show("Update user failed");
            }
        }

        private void doDelete()
        {
            MessageBox.Show("Delete User");
        }

        private void doRowClick(DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;

                UserDao dao = new UserDao();

                if (dgvRow.Cells["dg_id"].Value != DBNull.Value)
                {
                    dao.Id = (int)dgvRow.Cells["dg_id"].Value;
                }

                if (dgvRow.Cells["dg_user_id"].Value != DBNull.Value)
                {
                    dao.UserId = (int)dgvRow.Cells["dg_user_id"].Value;
                }

                if (dgvRow.Cells["dg_name"].Value != DBNull.Value)
                {
                    dao.Name = (string)dgvRow.Cells["dg_name"].Value;
                }

                if (dgvRow.Cells["dg_role"].Value != DBNull.Value)
                {
                    dao.Dept = (string)dgvRow.Cells["dg_role"].Value;
                }


                txtUserId.Text = dao.UserId+"";
                txtUserName.Text = dao.Name;
                cboRole.Text = dao.Dept;
                lblId.Text = dao.Id+"";

                action = "edit";
                btnSave.Enabled = true;

            }
            catch(Exception ee)
            {
                log.Error(" Error " + ee.Message);
            }
        }

        private void clear()
        {
            txtUserId.Text = "";
            txtUserName.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            action = "add";
            btnSave.Enabled = true;
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            doDelete();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doRowClick(e);
        }
    }
}
