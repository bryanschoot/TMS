using System.Collections.Generic;
using TMS.Model;

namespace TMS.Logic.Interface
{
    public interface IUserLogic
    {
        UserModel GetUser(int id);

        List<UserModel> GetAll();
    }
}