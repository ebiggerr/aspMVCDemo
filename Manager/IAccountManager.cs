using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Manager
{
    public interface IAccountManager
    {
        List<AccountDto> GetAll();

        AccountDto GetByUsername(string username);

        Task<Account> CreateAccount(CreateAccountDto input);

        Task<Account> UpdateAccount(UpdateAccountDto input);

        Task DeleteAccount(Guid id);
    }
}