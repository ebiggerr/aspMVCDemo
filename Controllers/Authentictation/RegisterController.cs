using System.Web.Mvc;
using aspMVCDemo.HelperServices;
using aspMVCDemo.Manager;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Controllers.Authentictation
{
    public class RegisterController : Controller, IRegisterController
    {
        private readonly AccountManager _accountManager;

        public RegisterController(AccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        // GET: Register
        public ActionResult Index()
        {
            ViewBag.Title = "Register";
            return View("Register");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CreateAccountDto input)
        {
            bool validPassword = Authentication.PasswordConfirmation(input.Password, input.ConfirmPassword);
            
            if (ModelState.IsValid && validPassword)
            {
                var acc = _accountManager.CreateAccount(input);

                if (acc.Result == null)
                {
                    //Registration failed
                    ViewBag.Error = "Unsuccessful registration.";
                    return RedirectToAction("Index","Register");
                }
                
                // Successful registration
                ViewBag.Error = "Successful registration. Click \"Ok\" and Go to Login Page...";
                return RedirectToAction("Index","Login");
            }

            //Registration failed
            ViewBag.Error = "Unsuccessful registration.";
            return View("Register");
        }
    }
}