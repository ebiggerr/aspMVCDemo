using System.Collections.Generic;
using System.Threading.Tasks;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Manager
{
    public interface IAccountManager
    {
        List<AccountDto> GetAll();

        Task CreateAccount(CreateAccountDto input);
    }
}