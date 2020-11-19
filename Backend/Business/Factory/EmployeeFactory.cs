namespace Business
{
    using Common;

    public static class EmployeeFactory
    {
        public static EmployeeDTO CreateEmployee(Employee employee)
        {
            EmployeeDTO result = null;

            if (employee != null)
            {
                switch (employee.ContractTypeName)
                {
                    case "HourlySalaryEmployee":
                        result = EmployeeDTO.NewHourlyEmployee(employee.Id, employee.Name, employee.ContractTypeName, employee.RoleName, employee.HourlySalary);
                        break;

                    case "MonthlySalaryEmployee":
                        result = EmployeeDTO.NewMonthlyEmployee(employee.Id, employee.Name, employee.ContractTypeName, employee.RoleName, employee.HourlySalary);
                        break;
                }
            }

            return result;
        }
    }
}