using POS.BusinessLogic.Service;
using POS.DAL;
using POS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLogic
{
    public class UserController:IUserService
    {
        UserDataController userDataController;
        public UserController()
        {
            userDataController = new UserDataController();
        }

        public List<UserModel> GetUserList()
        {
            return userDataController.GetUserList();
        }

        public bool SaveUser(UserModel userModel)
        {
            return userDataController.SaveUser(userModel);
        }
    }
}
