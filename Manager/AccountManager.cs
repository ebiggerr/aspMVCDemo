using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspMVCDemo.Models.Account;
using aspMVCDemo.Repository;
using AutoMapper;

namespace aspMVCDemo.Manager
{
    public class AccountManager : IAccountManager
    {
        private readonly AccountRepo _accountRepo;
        private IMapper _IMapper;
        private MapperConfiguration config;

        public AccountManager(AccountRepo accountRepo)
        {
            _accountRepo = accountRepo;
            this.InitializeMapperConfig();
        }

        private void InitializeMapperConfig()
        {
            //singleton
            if (config != null)
            {
            }
            else
            {
                //config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountDto>());
                config = new MapperConfiguration(cfg =>
                    //TODO nested mappings
                    cfg.CreateMap<Account, AccountDto>());
                _IMapper = config.CreateMapper();
            }
            
        }

        public List<AccountDto> GetAll()
        {
            var accounts = _accountRepo.GetAll();

            // Filtering out all the soft deleted accounts
            accounts = accounts.Where(x => x.IsDeleted == false || x.IsDeleted == null).ToList();

            return _IMapper.Map<List<Account>,List<AccountDto>>(accounts);
        }

        public AccountDto GetByUsername(string username)
        {
            var acc = _accountRepo.GetByUsername(username);
            
            return _IMapper.Map<Account,AccountDto>(acc);
        }

        public async Task<Account> CreateAccount(CreateAccountDto input)
        {
            // Using the 'Create" method in the entity to populate other attributes
            var acc = Account.Create(input);

            acc = await _accountRepo.Save(acc);    

            return acc;
        }

        public async Task<Account> UpdateAccount(UpdateAccountDto input)
        {
            // Get the entity
            var acc = _accountRepo.GetById(input.Id);

            // Do the update
            acc.Update(input);

            // Save changes
            var result = await _accountRepo.Update(acc);
            
            return result;
        }

        public async Task DeleteAccount(Guid id)
        {
            var acc = _accountRepo.GetById(id);
            acc.Delete();

            acc = await _accountRepo.Update(acc);
        }
    }
}