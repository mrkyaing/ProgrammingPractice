using POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLogic.Service
{
    public interface IUserService
    {
        List<UserModel> GetUserList();
        UserModel GetUserListById(string userId);
        bool SaveUser(UserModel userModel);
        bool DeleteUserById(string userId);
        bool UpdateUser(UserModel userModel);
        bool CheckUserAlreadyExists(UserModel userModel);
        UserModel LoginUser(UserModel userModel);
    }
}
