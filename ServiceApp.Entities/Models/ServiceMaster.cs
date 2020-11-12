using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Entities.Models
{
    public class ServiceMaster
    {
        public long Id { get; set; }
        public int serviceTypeId { get; set; }
       
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string serviceName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
