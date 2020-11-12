using ServiceApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Services
{
    public interface ICountryRepository : IRepositoryBase<CountryMaster>
    {
    }
}
