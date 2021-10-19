using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Controllers.Authentictation
{
    public class RegisterController : Controller, IRegisterController
    {
        // GET: Register
        public ActionResult Index()
        {
            ViewBag.Title = "Register";
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(CreateAccountDto input)
        {

            return RedirectToAction("Index","Login");
        }
    }
}