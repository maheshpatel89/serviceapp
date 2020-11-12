using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Entities.Models
{
   public class ServiceTypeMaster
    {
        public long Id { get; set; }
        public string serviceTypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
