using System.Web.Mvc;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Controllers.Authentictation
{
    public interface ILoginController
    {
        ActionResult Index();

        ActionResult Login(CreateAccountDto input);
    }
}