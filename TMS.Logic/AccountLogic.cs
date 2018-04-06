using TMS.Logic.Interface;
using TMS.Model;
using TMS.Repository.Interface;

namespace TMS.Logic
{
    public class AccountLogic : IAccountLogic
    {
        private IAccountRepository Repository;
        public AccountLogic(IAccountRepository repository)
        {
            this.Repository = repository;
        }
        public bool CheckLogin(AccountModel account) => Repository.Exists(account);
    }
}