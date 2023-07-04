using mtqstores.Global;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
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
    public partial class FormGaugeBorrowReturnHistory : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public FormGaugeBorrowReturnHistory()
        {
            InitializeComponent();
            init();
        }
         


        private void init()
        {
            dtpFromDate.Value = DateTime.Parse("01-" + currentMonth() + "-" + getCurrentYear());
            ///dtpToDate.Value = DateTime.Parse("31-" + currentMonth() + "-" + getCurrentYear());
        }

        private string currentMonth()
        {
            return DateTime.Now.ToString("MM");
        }

        private string getCurrentYear()
        {
            return DateTime.Now.ToString("yyyy");
        }

        private void loadDG()
        {
            String sql = "select id, equip_tag,  borrowed_by, returned_by, borrowed_on, returned_on, borrow_comments, return_comments, status" +
                "  from t_gague_trans ";
            try
            {



                //date
                DateTime dtFrom = dtpFromDate.Value;
                DateTime dtTo = dtpToDate.Value;
                if (sql.Contains("where "))
                {
                    sql = sql + " and borrowed_on>='" + dtFrom.ToString("yyyy-MM-dd") + "' and borrowed_on<='" + dtTo.ToString("yyyy-MM-dd") + "' ";
                }
                else
                {
                    sql = sql + " where  borrowed_on>='" + dtFrom.ToString("yyyy-MM-dd") + "' and borrowed_on<='" + dtTo.ToString("yyyy-MM-dd") + "' ";
                }

                if (!string.IsNullOrEmpty(txtEquipTag.Text))
                {
                    if (sql.Contains("where "))
                    {
                        sql = sql + " and equip_tag ='" + txtEquipTag.Text + "'  ";
                    }
                    else
                    {
                        sql = sql + " where  equip_tag  ='" + txtEquipTag.Text + "'  ";
                    }
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

                                    /* try
                                     {
                                         MySqlDateTime exp_date = (MySqlDateTime)dataGridView1.Rows[i].Cells["dgexp_date"].Value;
                                         String strDt = exp_date.Value.ToString("yyyy-MM-dd");
                                         DateTime dtx = DateTime.Parse(strDt);
                                         if (dtx < DateTime.Now)
                                         {
                                             dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Salmon;
                                         }
                                         //log.Info("dgexp_date = " + exp_date.Value.ToString("yyyy-MM-dd"));
                                     }
                                     catch (Exception ee)
                                     {
                                         log.Info("Error " + ee);
                                     }*/
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadDG();
        }

        private void btnExport2Excel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to export to Excel ", "Export 2 Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                MYGlobal.export2Excel(dataGridView1, "Expiring");
            }
        }

    }
}
