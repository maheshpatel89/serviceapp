using ServiceApp.Entities;
using ServiceApp.Services;
using System.Threading.Tasks;

namespace ServiceApp.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private readonly ServiceAppQDbContext _ServiceAppContext;


        public RepositoryWrapper(ServiceAppQDbContext ServiceAppContext)
        {
            _ServiceAppContext = ServiceAppContext;
        }

        private IUserRoleRepositories _userRepository;

        private ICountryRepository _countryRepository;

        private IServiceTypeRepository _ServiceTypeRepository;
        private IServiceRepository _ServiceRepository;

        private IAccountRepository _AccountRepository;

        public async Task Save()
        {
            await _ServiceAppContext.SaveChangesAsync();
        }

        public IUserRoleRepositories UserRepo
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRoleRepositories(_ServiceAppContext);
                }
                return _userRepository;
            }
        }


        //public IAccountRepository AccountRepo
        //{
        //    get
        //    {
        //        if (_AccountRepository == null)
        //        {
        //            _AccountRepository = new AccountRepository(_ServiceAppContext);
        //        }
        //        return _AccountRepository;
        //    }
        //}

        ICountryRepository IRepositoryWrapper.CountryRepo => _countryRepository = new CountryRepository(_ServiceAppContext);

        IServiceTypeRepository IRepositoryWrapper.ServiceTypeRepo => _ServiceTypeRepository = new ServiceTypeRepository(_ServiceAppContext);

        IServiceRepository IRepositoryWrapper.ServiceRepo => _ServiceRepository = new ServiceRepository(_ServiceAppContext);

        IAccountRepository IRepositoryWrapper.AccountRepo => _AccountRepository = new AccountRepository(_ServiceAppContext);
    }

   
}
