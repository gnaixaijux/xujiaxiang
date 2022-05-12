using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410703701.Controllers
{
    public class USERController : Controller
    {
        // GET: USER
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(string name,string account,string password) 
        {
            if (name == null || name == "")
            {
                ViewBag.NameMessage = "請輸入名字";
            }
            if (account == null || account == "") {
                ViewBag.AccountMessage = "請輸入帳號";
            }
            if (password == null || password == "")
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }
            if (name != "" && account != "" && password != "")
            {
                ViewBag.Message = "註冊成功";
            }
            return View();
        }
    }
}