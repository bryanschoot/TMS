using TMS.Model;

namespace TMS.Logic.Interface
{
    public interface IAccountLogic
    {
        bool CheckLogin(AccountModel account);
    }
}