using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.ViewModels
{
    public class LookUpViewModel
    {
        public int LookUpID { get; set; }
        public string LookUpCode { get; set; }
        public string LookUpDescription { get; set; }
        public string LookUpCategory { get; set; }
        public bool IsActive { get; set; }
    }
}