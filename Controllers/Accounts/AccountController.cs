using System.Linq;
using System.Web.Mvc;
using System.Web.Profile;
using aspMVCDemo.Manager;
using aspMVCDemo.Models.Account;
using ProfileManager = aspMVCDemo.Manager.Profile.ProfileManager;

namespace aspMVCDemo.Controllers.Accounts
{
    public class AccountController : Controller, IAccountController
    {
        private readonly AccountManager _accountManager;
        private readonly Manager.Profile.ProfileManager _profileManager;

        public AccountController(AccountManager accountManager,
            ProfileManager profileManager)
        {
            _accountManager = accountManager;
            _profileManager = profileManager;
        }

        // GET: Accounts
        [Route("/accounts")]
        [Authorize]
        public ActionResult Accounts()
        {
            //var list = GetData();
            var list = _accountManager.GetAll().Join(_profileManager.GetAll(), x => x.Profile_Id, y => y.Id, (x,y) => new AccountDto()
            {
                Id = x.Id,
                Profile_Id = x.Profile_Id,
                Username = x.Username,
                Name = y.Name
            });
            //ViewBag.Data = list;

            return View("Accounts", list);
        }

        [Route("/accounts/{username}")]
        [Authorize]
        public ActionResult AccountDetails(string username)
        {
            var item = _accountManager.GetByUsername(username);
            
            ViewBag.Data = item;
            
            return View("AccountDetails");
        }
    }
}