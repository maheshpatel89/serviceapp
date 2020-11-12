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
    public class AccountController : BaseController
    {

        private readonly IRepositoryWrapper RepositoryWrapper;
        private readonly IMapper Mapper;
        public AccountController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            RepositoryWrapper = repositoryWrapper;
            Mapper = mapper;
        }

        [HttpPost]
        [Route("RegistrationUser")]
        public async Task<ExecutionResult> RegistrationUser(AccountModel AccountModel)
        {
            try
            {
                //AccountModel.RoleId = 4;
                //AccountModel.CreatedDate = DateTime.Now;
                //AccountModel.ModifiedDate = DateTime.Now;
                await RepositoryWrapper.AccountRepo.Create(Mapper.Map<AccountMaster>(AccountModel));
                await RepositoryWrapper.Save();
                return new ExecutionResult(new InfoMessage("User added successfully."));
            }
            catch (Exception ex)
            {
                return new ExecutionResult(new ErrorInfo(ex.Message));
            }
        }

        [HttpPost]
        [Route("LoginUser")]
        public async Task<ExecutionResult> LoginUser(string EmailId, string Password)
        {
            try
            {
                var demo = await RepositoryWrapper.AccountRepo.GetAllByCondition(x => x.EmailId == EmailId && x.Password == Password && x.IsActive == true);
                if (demo.Count > 0)
                {
                    return new ExecutionResult(new InfoMessage("Login successfully."));
                }
                else
                {
                    return new ExecutionResult(new InfoMessage("Login Failed."));
                }

            }
            catch (Exception ex)
            {
                return new ExecutionResult(new ErrorInfo(ex.Message));
            }
        }



    }
}
