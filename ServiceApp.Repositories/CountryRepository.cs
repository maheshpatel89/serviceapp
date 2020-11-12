using ServiceApp.Entities;
using ServiceApp.Entities.Models;
using ServiceApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Repositories
{
    public class CountryRepository : RepositoryBase<CountryMaster, ServiceAppQDbContext>, ICountryRepository
    {
        public CountryRepository(ServiceAppQDbContext ServiceAppContext)
          : base(ServiceAppContext)
        {
        }
    }
}
