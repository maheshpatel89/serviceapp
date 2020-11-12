using ServiceApp.Entities;
using ServiceApp.Entities.Models;
using ServiceApp.Services;

namespace ServiceApp.Repositories
{
    public class ServiceRepository : RepositoryBase<ServiceMaster, ServiceAppQDbContext>, IServiceRepository
    {
        public ServiceRepository(ServiceAppQDbContext ServiceAppContext)
            : base(ServiceAppContext)
        {
        }
    }
}
