using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtqstores.DB
{
   public class EquipmentTransHistoryDao
    {
        public int Id { set; get; }
        public string EquipTag { set; get; }
        public int BorrowedBy { set; get; }
        public int ReturnedBy { set; get; }
        public DateTime BorrowedOn { set; get; }
        public DateTime RequrnedOn { set; get; }
        public string BorrowComments { set; get; }
        public string ReturnedComments { set; get; }
        public int Status { set; get; }
        public string StatusStr { set; get; }
        public string StatusRemark { set; get; }
    }
}
