using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceApp.Entities.Models;
using ServiceApp.Services;
using ServiceApp.Utilities.ApiResponse;
using ServiceApp.Utilities.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IRepositoryWrapper RepositoryWrapper;
        private readonly IMapper Mapper;
        public UserController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            RepositoryWrapper = repositoryWrapper;
            Mapper = mapper;
        }

        // GET: api/<UserController>
        [HttpPost]
        public async Task<ExecutionResult> createrole(UserRoleModel userRoleModel)
        {
            try
            {
                await RepositoryWrapper.UserRepo.Create(Mapper.Map<UserRole>(userRoleModel));
                await RepositoryWrapper.Save();
                return new ExecutionResult(new InfoMessage("User Role added successfully."));
            }
            catch (Exception ex)
            {
                return new ExecutionResult(new ErrorInfo(ex.Message));
            }
        }




    }
}
