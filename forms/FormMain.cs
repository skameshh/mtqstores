using mtqstores.DB;
using mtqstores.Global;
using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnEquipments.BackColor = Color.DarkGray;
            btnGagues.BackColor = Color.DarkGray;

            init();
        }

        private void init()
        {
            btnEquipments.Enabled = false;
            btnGagues.Enabled = false;

            //doDBConnectionTest(); moved to timer
            
        }

        private void doDBConnectionTest()
        {
            bool bb = MYGlobal.checkConnection();

            if (bb)
            {
                btnEquipments.Enabled = true;
                btnGagues.Enabled = true;

                lblDBStatus.Text = "DB Connection Success";

                btnEquipments.BackColor = Color.DarkSlateBlue;
                btnGagues.BackColor = Color.DarkSlateBlue;
            }
            else
            {
                lblDBStatus.Text = "DB Connection failed, Please start Database ";
                lblDBStatus.ForeColor = Color.Red;
            }
        }

        private void btnGagues_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormGaguesMain frm = new FormGaguesMain();
            frm.Visible = true;
        }

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEquipmentsMain frm = new FormEquipmentsMain();
            frm.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            doDBConnectionTest();
            lblDBServer.Text = "Database: "+ MYGlobal.MYSQL_SERVER;
        }

        private void doSendEmail()
        {
            String msg = "<html><h1> Helllo there </h1></html>";
            //(String fromEmail, String who, String subject, String to, String cc, String bcc, String message)
            MYGlobal.sendHALSMTPEmail("noreply.mtqapp@mail.mtq.com.sg", "Admin", "MTQApp Alert", "skameshh@gmail.com", null, null, msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
               // Application.Exit();
                System.Environment.Exit(1);
               // e.Cancel= false;
            }

          /*  if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Application.Exit();
                    e.Cancel = false;
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }*/



        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
