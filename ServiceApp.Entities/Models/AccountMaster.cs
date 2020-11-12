using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Entities.Models
{
   public class AccountMaster
    {
        public long Id { get; set; }

        public long RoleId { get; set; }

        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
