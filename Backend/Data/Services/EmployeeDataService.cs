namespace Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Common;
    using Refit;

    public interface IEmployeeWebService
    {        
        [Get("/api/Employees")]
        Task<List<Employee>> GetEmployees();
    }

    public class EmployeeDataService : IEmployeeDataService
    {
        public async Task<IEnumerable<Employee>> GetEmployee(int id)
        {
            var result = await GetEmployees();
            return result.Where(x=> x.Id == id);
        }

        public async Task<ICollection<Employee>> GetEmployees()
        {
            var result = await RestService.For<IEmployeeWebService>(GlobalSettings.UrlBase).GetEmployees();
            return result;
        }
    }
}