using System;
using System.Collections.Generic;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Repository
{
    public interface IAccountRepo : IDisposable
    {
        List<Account> GetAll();
    }
}