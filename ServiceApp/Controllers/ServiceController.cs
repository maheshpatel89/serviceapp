using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceApp.Entities.Models;
using ServiceApp.Services;
using ServiceApp.Utilities.ApiResponse;
using ServiceApp.Utilities.Models;
namespace ServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : BaseController
    {
        private readonly IRepositoryWrapper RepositoryWrapper;
        private readonly IMapper Mapper;

        public ServiceController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            RepositoryWrapper = repositoryWrapper;
            Mapper = mapper;
        }

        [HttpPost]
        [Route("createServiceType")]
        public async Task<ExecutionResult> createServiceType(ServiceTypeModel ServiceTypeModel)
        {
            try
            {
                await RepositoryWrapper.ServiceTypeRepo.Create(Mapper.Map<ServiceTypeMaster>(ServiceTypeModel));
                await RepositoryWrapper.Save();
                return new ExecutionResult(new InfoMessage("Service Type added successfully."));
            }
            catch (Exception ex)
            {
                return new ExecutionResult(new ErrorInfo(ex.Message));
            }
        }

        [HttpPost]
        [Route("createService")]
        public async Task<ExecutionResult> createService(ServiceModel ServiceModel)
        {
            try
            {
                await RepositoryWrapper.ServiceRepo.Create(Mapper.Map<ServiceMaster>(ServiceModel));
                await RepositoryWrapper.Save();
                return new ExecutionResult(new InfoMessage("Service Type added successfully."));
            }
            catch (Exception ex)
            {
                return new ExecutionResult(new ErrorInfo(ex.Message));
            }
        }
    }
}
