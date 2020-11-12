using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Utilities.Models
{
   public class StateModel
    {
        public long Id { get; set; }
        public int CountryId { get; set; }
        public string StateName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
