using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stepByStepMVC.Models;
using stepByStepMVC.ViewModels;

namespace stepByStepMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public string GetString()
        {
            return "Hello World";
        }

        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            employeeListViewModel.Employees = populateEmployeeListView();

            return View("Index", employeeListViewModel);
        }

        private List<EmployeeViewModel> populateEmployeeListView()
        {
            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

            foreach (Employee temp in loadEmployeeList())
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();

                employeeViewModel.EmployeeName = temp.FirstName + " " + temp.LastName;
                employeeViewModel.Salary = temp.Salary.ToString("C");
                employeeViewModel.SalaryColor = defineSalaryColor(temp.Salary);

                employeeViewModels.Add(employeeViewModel);
            }
            return employeeViewModels;
        }

        private List<Employee> loadEmployeeList()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            return employeeBusinessLayer.GetEmployees();
        }

        private string defineSalaryColor(int salary)
        {
            if (salary > 5000)
            {
                return "yellow";
            }
            else
            {
                return "green";
            }
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee employee, string SubmitButton)
        {
            if(SubmitButton.Equals("Save Employee"))
            {
                if(ModelState.IsValid)
                {
                    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                    employeeBusinessLayer.SaveEmployee(employee);
                }
                else
                {
                    return View("CreateEmployee");
                }
            }
                return RedirectToAction("Index");
        }
    }
}
