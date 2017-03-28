using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stepByStepMVC.Models;

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
            
            return View("MyView", employee);
        }
    }

}