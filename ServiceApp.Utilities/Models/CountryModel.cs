using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Utilities.Models
{
  public  class CountryModel
    {
        public long Id { get; set; }
        public string CountryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
