using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Mime;
using Common.Database;
using Common.Database.Models;

namespace WebServer.Controllers
{
    [ApiController]
    [Route("api")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly CommonContext _context;

        public EmployeeController(ILogger<EmployeeController> logger, CommonContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("/Employees")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployeesAysnc()
        {
            var employees = this._context.Employees.ToList();
            if (employees.Count == 0) 
            {
                return NotFound();
            }
            return CreatedAtAction("GetEmployees",employees);
        }
    }
}

