namespace Data
{
    using System.Collections.Generic;
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
        public async Task<ICollection<Employee>> GetEmployees()
        {
            var result = await RestService.For<IEmployeeWebService>(GlobalSettings.UrlBase).GetEmployees();
            return result;
        }
    }
}