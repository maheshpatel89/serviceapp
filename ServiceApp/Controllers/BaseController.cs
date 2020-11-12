using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceApp.Utilities.ApiResponse;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult FromExecutionResult(ExecutionResult result)
        {
            if (result.Success)
                return Ok(result);
            return BadRequest(result.Errors);
        }

        protected IActionResult FromExecutionResult<T>(GenericExecutionResult<T> result, object value = null)
        {
            if (result.Success)
                return Ok(value ?? result);
            return BadRequest(result.Errors);
        }
    }
}
