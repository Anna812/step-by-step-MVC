﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using stepByStepMVC.DataAccessLayer;

namespace stepByStepMVC.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDataAccessLayer salesERPDataAccessLayer = new SalesERPDataAccessLayer();
            return salesERPDataAccessLayer.Employees.ToList();
        }
    }
}