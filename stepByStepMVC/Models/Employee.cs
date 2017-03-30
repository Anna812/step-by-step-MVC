using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace stepByStepMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }
        [StringLength(5, ErrorMessage = "Last name should not be more than 5 characters")]
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}