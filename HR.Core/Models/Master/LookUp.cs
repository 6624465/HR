using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models.Master
{
    public class LookUp
    {
        public int LookUpID { get; set; }
        public string LookUpCode { get; set; }
        public string LookUpDescription { get; set; }
        public string LookUpCategory { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
