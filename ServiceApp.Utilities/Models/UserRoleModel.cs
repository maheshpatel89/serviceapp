using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Utilities.Models
{
   public class UserRoleModel
    {
        public long Id { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
