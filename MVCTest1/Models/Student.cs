using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest1.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
    }
}