using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-z0-9-]+\.[a-zA-Z0-9-.]+$")]
        public required string Email { get; set; }
        public required Dept? Department { get; set; }
    }
}
