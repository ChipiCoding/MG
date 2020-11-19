namespace Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Common;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeBusinessService employeeService;

        public EmployeeController(IEmployeeBusinessService employeeService)
        {
            this.employeeService = employeeService;
        }
        // GET: api/Employee
        [HttpGet]
        public async Task<IEnumerable<EmployeeDTO>> Get()
        {
            return await employeeService.GetEmployees();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
    }
}