using ServiceApp.Entities;
using ServiceApp.Entities.Models;
using ServiceApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Repositories
{
    public class AccountRepository : RepositoryBase<AccountMaster, ServiceAppQDbContext>, IAccountRepository
    {
        public AccountRepository(ServiceAppQDbContext ServiceAppContext)
           : base(ServiceAppContext)
        {
        }
    }
}
