using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtqstores.MyDGV
{
    public class MYDgv : DataGridView
    {
        public MYDgv()
        {
            //this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //this will make it bit slow
            // this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DoubleBuffered = true;
        }
    }
}
