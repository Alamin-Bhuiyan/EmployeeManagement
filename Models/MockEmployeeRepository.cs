
namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Alamin", Department = "CSE", Email = "alamin@gmail.com" },
                new Employee() { Id = 2, Name = "vanga", Department = "CSE", Email = "alamin@gmail.com" }
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.First(e => e.Id == Id);
        }
    }
}
