using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return _context.Accounts.Include("Profile").ToList();
        }

        public Account GetById(Guid id)
        {
            return _context.Accounts.Find(id);
        }

        public Account GetByUsername(string username)
        {
            return _context.Accounts.Include("Profile").FirstOrDefault(x => x.Username == username);
        }

        public async Task<Account> Save(Account acc)
        {
            var insert = _context.Accounts.Add(acc);

            await _context.SaveChangesAsync();

            return insert;
        }

        public async Task<Account> Update(Account acc)
        {
            await _context.SaveChangesAsync();
            return acc;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}