using Framwork_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Framwork_MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student stu)
        {
            if (ModelState.IsValid)
            {
                // TO DO
                return View();
            }
            return View();
        } 
    }
}
