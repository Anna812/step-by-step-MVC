using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stepByStepMVC.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee();
            employee.FirstName = "Dora";
            employee.LastName = "Fazekas";
            employee.Salary = 4000;
            employees.Add(employee);

            employee = new Employee();
            employee.FirstName = "michael";
            employee.LastName = "jackson";
            employee.Salary = 16000;
            employees.Add(employee);

            employee = new Employee();
            employee.FirstName = "robert";
            employee.LastName = " pattinson";
            employee.Salary = 20000;
            employees.Add(employee);

            return employees;
        }
    }
}