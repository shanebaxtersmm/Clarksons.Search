using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clarksons.Search.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clarkson.Search.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _manager;
        public EmployeeController(IEmployeeManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        [Route("find/{lastname:maxlength(40):regex(^[[a-zA-Z0-9]]*$)}")]
        //api/employee/find/baxter
        public IActionResult Find(string lastname)
        {
            if (ModelState.IsValid && !string.IsNullOrWhiteSpace(lastname))
            {
                var results = _manager.Find(lastname);

                return Ok(results);
            }

            return BadRequest();
        }

    }
}