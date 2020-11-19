namespace Business
{
    using Common;

    public static class EmployeeFactory
    {
        public static EmployeeDTO CreateEmployee(Employee employee)
        {
            if (employee != null)
            {
                if (employee.ContractTypeName == GlobalSettings.HourlyContract)
                {
                    return EmployeeDTO.NewHourlyEmployee(employee.Id, employee.Name, employee.ContractTypeName, employee.RoleName, employee.HourlySalary);
                }

                return EmployeeDTO.NewMonthlyEmployee(employee.Id, employee.Name, employee.ContractTypeName, employee.RoleName, employee.MonthlySalary);
            }

            return null;
        }
    }
}