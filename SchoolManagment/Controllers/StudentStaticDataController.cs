using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagment.Models;

namespace SchoolManagment.Controllers
{
    public class StudentStaticDataController : Controller
    {
        // GET: StudentStaticData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadStudent()
        {
            Student stu =
                new Student
                {
                    RollNo = "101",
                    StudentName ="shivam"
                };

            return View(stu);
        }
    }
}