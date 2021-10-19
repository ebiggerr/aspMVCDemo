using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspMVCDemo.HelperServices;
using aspMVCDemo.Manager;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Controllers.Authentictation
{
    public class LoginController : Controller, ILoginController
    {
        private readonly AccountManager _accountManager;

        public LoginController(AccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Login";
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(CreateAccountDto input)
        {
            bool valid = false;
            
            if (ModelState.IsValid)
            {
                var exist = _accountManager.GetByUsername(input.Username);

                if (exist != null)
                {
                    valid = Authentication.ValidatePassword(exist.Password, input.Password);

                    if (valid)
                    {
                        
                    }
                }
            }

            ViewBag.Error = "Login Failed";
            return RedirectToAction("Index");
        }
    }
}