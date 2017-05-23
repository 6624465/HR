using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models.Master
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string RegNo { get; set; }
        public byte[] Logo { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
    }
}
