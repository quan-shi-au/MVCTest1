using MVCTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest1.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> studentsList = new List<Student>();

        static StudentController()
        {
            studentsList.Add
            (
                new Student
                {
                    FirstName = "Dummy",
                    LastName = "Dummy",
                    DOB = DateTime.Now.AddYears(-18),
                    FathersName = "Dummy",
                    MothersName = "Dummy"
                }
            );
        }

        //
        // GET: /Student/

        public ActionResult Index()
        {
            return View(studentsList);
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Student student = new Student();

                student.FirstName = collection["FirstName"];
                student.LastName = collection["LastName"];
                DateTime suppliedDate;
                DateTime.TryParse(collection["DOB"], out suppliedDate);
                student.DOB = suppliedDate;
                student.FathersName = collection["FathersName"];
                student.MothersName = collection["MothersName"];

                studentsList.Add(student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateWithStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateWithStudent(Student student)
        {
            try
            {
                studentsList.Add(student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}