using mtqstores.forms;
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

namespace mtqstores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = ""+ MYGlobal.VERSION;
        }

        int ans = 0;
        private int doReverse(int num)
        {          

            if (num == 0)
            {
                return ans;
            }
            else
            {
                int temp = num % 10;
                ans = ans * 10 + temp;
                int x = num / 10;
                doReverse(x);
            }



            return ans;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int rev= doReverse(12345);
            Console.WriteLine("Rev " + rev);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Visible = false;
            FormMain frm = new FormMain();
            frm.Visible = true;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult res =MessageBox.Show("Are you sure to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
