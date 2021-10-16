using System.Collections.Generic;
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
                config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountDto>());
                _IMapper = config.CreateMapper();
            }
            
        }

        public List<AccountDto> GetAll()
        {
            var accounts = _accountRepo.GetAll();

            return _IMapper.Map<List<Account>,List<AccountDto>>(accounts);
        }

        public Task CreateAccount(CreateAccountDto input)
        {


            return null;
        }
    }
}