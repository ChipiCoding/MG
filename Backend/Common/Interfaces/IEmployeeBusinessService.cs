namespace Common
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeBusinessService
    {
        Task<IEnumerable<EmployeeDTO>> GetEmployee(int id);
        Task<IEnumerable<EmployeeDTO>> GetEmployees();
    }
}