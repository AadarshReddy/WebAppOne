using Microsoft.AspNetCore.Mvc;
using WebAppOne.Models;

namespace WebAppOne.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> listemps = new List<Employee>()
        {
            new Employee{Id=1,Name="Sam",Designation="Manager",Salary=98000,DOJ = new DateTime(day:12,month:1,year:2021)},
            new Employee{Id=2,Name="Ritu",Designation="Hr",Salary=78000,DOJ = new DateTime(day:22,month:6,year:2020)},
            new Employee{Id=3,Name="Janu",Designation="Tester",Salary=65000,DOJ = new DateTime(day:19,month:7,year:2022)},
            new Employee{Id=4,Name="Amit",Designation="Developer",Salary=96000,DOJ = new DateTime(day:29,month:10,year:2008)}
        };
        public IActionResult Index()
        {
            return View(listemps);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            
            if(emp != null) { 
                if(ModelState.IsValid)
                {
                    listemps.Add(emp);
                    return RedirectToAction("Index");
                }
            }
            return View(emp);
        }

    }
}
