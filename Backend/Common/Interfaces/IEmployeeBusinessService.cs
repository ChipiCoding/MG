namespace Common
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeBusinessService
    {
        Task<IEnumerable<EmployeeDTO>> GetEmployees();
    }
}