namespace Common
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeDataService
    {
        Task<ICollection<Employee>> GetEmployees();
    }
}