namespace Test.Employee
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Business;
    using Common;
    using Moq;
    using Xunit;

    public class EmployeeTest
    {
        Mock<IEmployeeDataService> employeeDataServiceMock;
        readonly IEmployeeBusinessService employeeBusinessService;

        Employee employee = new Employee();

        public EmployeeTest()
        {
            employeeDataServiceMock = new Mock<IEmployeeDataService>();
            employeeBusinessService = new EmployeeBusinessService(employeeDataServiceMock.Object);
        }

        [Fact]
        public void CalculateMonthlySalary()
        {
            //Arrange
            employee.ContractTypeName = GlobalSettings.MonthlyContract;
            employee.Id = 1;
            employee.MonthlySalary = 2500000;
            employee.Name = "Rocky Balboa";

            //act
            var _employee = EmployeeFactory.CreateEmployee(employee);

            //Assert
            Assert.Equal(30000000, _employee.AnnualSalary);
        }

        [Fact]
        public void CalculateHourlySalary()
        {
            //Arrange
            employee.ContractTypeName = GlobalSettings.HourlyContract;
            employee.Id = 1;
            employee.HourlySalary = 25000;
            employee.Name = "Freddy Mercury";

            //act
            var _employee = EmployeeFactory.CreateEmployee(employee);

            //Assert
            Assert.Equal(36000000, _employee.AnnualSalary);
        }

        [Fact]
        public async Task GetEmployees()
        {
            //Arrange
            var data = new List<Employee>()
            {
                new Employee
                {
                    Id= 1,
                    Name = "Faustino Asprilla",
                    ContractTypeName = GlobalSettings.MonthlyContract,
                    RoleDescription =  "Administrator",
                    MonthlySalary = 5000000,                    
                }
            };

            employeeDataServiceMock.Setup(x => x.GetEmployees()).ReturnsAsync(data);

            //act            
            var results = await employeeBusinessService.GetEmployees();
            var employee = results.First();

            //Assert
            Assert.Equal(60000000, employee.AnnualSalary);
        }
    }
}