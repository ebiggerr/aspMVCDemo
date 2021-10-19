using System.Web.Mvc;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Controllers.Authentictation
{
    public interface IRegisterController
    {
        ActionResult Index();

        ActionResult Register(CreateAccountDto input);
    }
}