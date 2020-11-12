using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Utilities.Models
{
   public class CityModel
    {
        public long Id { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
