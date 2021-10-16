using System.Web.Mvc;

namespace aspMVCDemo.Controllers.Accounts
{
    public interface IAccountController
    {
        ActionResult Accounts();

        ActionResult AccountDetails(string username);
    }
}