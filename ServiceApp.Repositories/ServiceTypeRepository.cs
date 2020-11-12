using ServiceApp.Entities;
using ServiceApp.Entities.Models;
using ServiceApp.Services;


namespace ServiceApp.Repositories
{
   public class ServiceTypeRepository : RepositoryBase<ServiceTypeMaster, ServiceAppQDbContext>, IServiceTypeRepository
    {
        public ServiceTypeRepository(ServiceAppQDbContext ServiceAppContext)
            : base(ServiceAppContext)
        {
        }
    }
}
