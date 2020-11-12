using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Services
{
    public interface IRepositoryWrapper
    {

        IUserRoleRepositories UserRepo { get; }

        ICountryRepository CountryRepo { get; }

        IServiceTypeRepository ServiceTypeRepo { get; }

        IServiceRepository ServiceRepo { get; }

        IAccountRepository AccountRepo { get; }


        Task Save();
    }
}
