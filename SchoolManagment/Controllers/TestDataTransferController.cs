using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagment.Controllers
{
    public class TestDataTransferController : Controller
    {
        // GET: TestDataTransfer
        public ActionResult Index()
        {
            //temp data maintain data action to action
            TempData["mytimeTemp"] = DateTime.Now.ToString();
            Session["MyTimeSession"]= DateTime.Now.ToString();

            //ViewBag and viewData both are not maintain data Action to Action 
            ViewData["MyTime"] = DateTime.Now.ToString();

        
            return RedirectToAction("datacontrol", "TestDataTransfer");
        }

        public ActionResult datacontrol()
        {
            //ViewData["MyTime"] = DateTime.Now.ToString();
            ViewBag.mytimenow = DateTime.Now.ToLongDateString();
            return View();
        }
    }
}