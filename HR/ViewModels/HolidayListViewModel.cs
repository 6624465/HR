using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.ViewModels
{
    public class HolidayListViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public Int16 BranchID { get; set; }
        public string BranchLocation { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime start { get; set; }
        public string title { get; set; }
        public string Location { get; set; }
    }
}