using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtqstores.DB
{
   public  class EquipmentDao
    {
        public int Id { set; get; }
        public String Dept { set; get; }
        public string Description { set; get; }
        public string Type { set; get; }
        public string TagNo { set; get; }
        public string Swl { set; get; }
        public string Length { set; get; }
        public int Qty { set; get; }
        public int AvailQty { set; get; }
        public DateTime ExpDate { set; get; }
        public string Remarks { set; get; }
        public string AddedBy { set; get; }
        public string AddedOn { set; get; }


    }
}
