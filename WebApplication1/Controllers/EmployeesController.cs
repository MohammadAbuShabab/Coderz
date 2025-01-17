using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeesController : Controller
    {
        List<Employee> employeesList =new List<Employee>{
            new Employee{
                Id=1,
                Name="ahmad",
                Cite="amman",
                HDate=DateTime.Now,
                IsActive=true,
                Salary=1500,

            }
            };
        public IActionResult AllEmployees()
        {
            return View(employeesList);

        }
        public IActionResult Details(int? id)
            
        {
            if (id == null) 
            {
                return RedirectToAction("AllEmployees");

            }
            var empData =(from x in employeesList
                where x.Id==id
                select x).SingleOrDefault();

            return View(empData); 
        

        }
    }
}
