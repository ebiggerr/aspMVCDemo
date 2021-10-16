using System;
using System.Collections.Generic;
using System.Linq;
using aspMVCDemo.EF;
using aspMVCDemo.Models.Account;

namespace aspMVCDemo.Repository
{
    public class AccountRepo : IAccountRepo
    {
        private readonly AspMVCDemoDbContext _context;

        public AccountRepo(AspMVCDemoDbContext DbContext)
        {
            _context = DbContext;
        }

        public List<Account> GetAll()
        {
            return _context.Accounts.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}