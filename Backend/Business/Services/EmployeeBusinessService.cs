namespace Business
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Common;

    public class EmployeeBusinessService : IEmployeeBusinessService
    {
        readonly IEmployeeDataService employeeDataService;

        public EmployeeBusinessService(IEmployeeDataService employeeDataService)
        {
            this.employeeDataService = employeeDataService;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            ICollection<Employee> _employees = await employeeDataService.GetEmployees();

            var result = _employees.Select(employee => EmployeeFactory.CreateEmployee(employee));

            return result;
        }
    }
}