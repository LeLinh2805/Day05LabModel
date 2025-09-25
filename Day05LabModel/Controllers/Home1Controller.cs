using Day05LabModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day05LabModel.Controllers
{
    public class Home1Controller : Controller
    {
        private List<Employee> employees = new List<Employee>()
    {
        new Employee { Id = 1, FullName = "Le Van Linh", Gender = "Male", Phone = "0901234567", Email = "linh234@gmail.com", Salary = 15000000, Status = true },
        new Employee { Id = 2, FullName = "Tran Thi quan", Gender = "Female", Phone = "0912345678", Email = "huhu123@gmail.com", Salary = 12000000, Status = false },
        new Employee { Id = 3, FullName = "Le Van duc", Gender = "Male", Phone = "0923456789", Email = "hahau88@gmail.com", Salary = 18000000, Status = true },
        new Employee { Id = 4, FullName = "Pham Thi Dung", Gender = "Female", Phone = "0934567890", Email = "dung11@gmail.com", Salary = 20000000, Status = true }
    };

        public IActionResult Index()
        {
            return View(employees);

        }

    }
}
