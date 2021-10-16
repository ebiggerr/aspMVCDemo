using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using aspMVCDemo.Manager;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Controllers.Accounts
{
    public class AccountController : Controller, IAccountController
    {
        private readonly AccountManager _accountManager;

        public AccountController(AccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        // GET: Accounts
        [Route("/accounts")]
        public ActionResult Accounts()
        {
            //var list = GetData();
            var list = _accountManager.GetAll();
            //ViewBag.Data = list;

            return View("Accounts", list);
        }

        [Route("/accounts/{username}")]
        public ActionResult AccountDetails(string username)
        {
            var list = GetData();

            var item = list.FirstOrDefault(x => x.Username == username);
            
            ViewBag.Data = item;
            
            return View("AccountDetails");
        }

        public List<CreateAccountDto> GetData()
        {
            List<CreateAccountDto> list = new List<CreateAccountDto>();
            list.Add( new CreateAccountDto("Testing 1", "Testing 1"));
            list.Add( new CreateAccountDto("Testing 2", "Testing 2"));
            list.Add( new CreateAccountDto("Testing 3", "Testing 3"));
            list.Add( new CreateAccountDto("Testing 4", "Testing 4"));


            return list;
        }
    }
}