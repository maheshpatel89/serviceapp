using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Entities.Models
{
    public class UserRole
    {
        public long Id { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
