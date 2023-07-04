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
    public partial class PdfViwer : Form
    {
        string filepath = "";
        public PdfViwer(string   filepath)
        {
            InitializeComponent();
            this.filepath = filepath;
        }

        private void PdfViwer_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("SRINATH SIRIWARDHDNA_CV.pdf");
        }
    }
}
