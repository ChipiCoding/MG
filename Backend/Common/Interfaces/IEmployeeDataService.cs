namespace Common
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetEmployee(int id);
        Task<ICollection<Employee>> GetEmployees();
    }
}