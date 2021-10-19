using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspMVCDemo.Manager;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Repository
{
    public interface IAccountRepo : IDisposable
    {
        List<Account> GetAll();

        Account GetById(Guid id);

        Account GetByUsername(string username);
        
        Task<Account> Save(Account acc);

        Task<Account> Update(Account acc);
    }
}