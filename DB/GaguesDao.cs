using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtqstores.DB
{
   public class GaguesDao
    {
        public int Id { set; get; }
        public string GageId { set; get; }
        public string GageDesc { set; get; }
        public string GageBrand { set; get; }
        public string GageRance { set; get; }
        public string GageSlNo { set; get; }
        public string GageCalibMethod { set; get; }
        public string Tolerance { set; get; }
        public DateTime CalibDate { set; get; }
        public int CalibInterval { set; get; }
        public string CalibIntervalUnit { set; get; }
        public DateTime CalibDueDate { set; get; }
        public string CalibAgency { set; get; }
        public string CalibCertNo { set; get; }
        public string GageLocation { set; get; }
        public string Remarks { set; get; }
        public string Comments { set; get; }

        public string MasterGageSlNo { set; get; }
        public string MasterGageCertNo { set; get; }
        public DateTime MasterGageValidDate { set; get; }
        public string GageStatus { set; get; }
        public string AddedBy { set; get; }
        public DateTime AddedOn { set; get; }

        public int Qty { set; get; }
        public int AvailQty { set; get; }
    }
}
