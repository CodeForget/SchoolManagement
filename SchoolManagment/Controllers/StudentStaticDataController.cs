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
        public ActionResult EnterStudentRecord()
        {
            return View("StudentRecord",new Student());
        }

        //public ActionResult Submit()
        //{
        //    Student stu = new Student();
        //    stu.RollNo = Request.Form["RollNo"];
        //    stu.StudentName = Request.Form["StudentName"];

        //    return View("LoadStudent",stu);
        //}


        //An other Way Do same

        public ActionResult Submit(Student stu)
        {
            //Student stu = new Student();
            //stu.RollNo = Request.Form["RollNo"];
            //stu.StudentName = Request.Form["StudentName"];
            if(ModelState.IsValid)
            {
                return View("LoadStudent", stu);
            }
            else
            {
                return View("StudentRecord", stu);
            }
            
        }


    }
}