using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTest1.Models
{
    public class Employee
    {
        public Guid ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Department")]
        public string Department { get; set; }
        [Display(Name = "Salary")]
        public double Salary { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}