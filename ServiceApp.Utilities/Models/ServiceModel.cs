using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Utilities.Models
{
    public class ServiceModel
    {
        public long Id { get; set; }
        public int serviceTypeId { get; set; }
        public string serviceName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
