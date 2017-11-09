using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.ViewModels
{
    public class UsersViewModel
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string RoleCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}