using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stepByStepMVC.Models;
using stepByStepMVC.ViewModels;

namespace stepByStepMVC.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello World";
        }

        public ActionResult GetView()
        {
            Employee employee = new Employee();
            employee.FirstName = "Piroska";
            employee.LastName = "Toth";
            employee.Salary = 150000;

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.EmployeeName = employee.FirstName + " " + employee.LastName;
            employeeViewModel.UserName = "admin";
            employeeViewModel.Salary = employee.Salary.ToString("C");

            if(employee.Salary > 5000)
            {
                employeeViewModel.SalaryColor = "yellow";
            }
            else
            {
                employeeViewModel.SalaryColor = "green";
            }

            return View("MyView", employeeViewModel);
        }
    }

}