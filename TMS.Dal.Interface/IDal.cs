using System;
using System.Collections.Generic;
using System.Text;
using TMS.Model;

namespace TMS.Dal.Interface
{
    public interface IDal
    {
        UserModel Read(int id);
        List<UserModel> GetAll();
    }
}
