using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository) 
        {
            _employeeRepository = employeeRepository;
        }
        [Route("")]
        [Route("/")]
        [Route("Index")]
        public ViewResult Index() 
        {
            //var name = _employeeRepository.GetEmployee(1).Name;
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        [Route("[action]/{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsviewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsviewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("details", new { id = newEmployee.Id });
            }

            return View();
        }
    }
}
