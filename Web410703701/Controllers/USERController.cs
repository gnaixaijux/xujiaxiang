using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web410703701.ViewModels;

namespace Web410703701.Controllers
{
    public class USERController : Controller
    {
        // GET: USER
        public ActionResult Signup()
        {
            return View(new SignUpData());
        }
        [HttpPost]
        public ActionResult Signup(SignUpData data) 
        {
            
            if (ModelState.IsValid)
            {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}