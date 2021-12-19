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

        public bool CheckUserAlreadyExists(UserModel userModel)
        {
            List<UserModel> users = userDataController.GetUserList();
            bool userExists = users.Where(u => u.Email.Equals(userModel.Email)).Any();
             return userExists;
        }

        public bool DeleteUserById(string userId)
        {
            return userDataController.DeleteUserById(userId);
        }

        public List<UserModel> GetUserList()
        {
            return userDataController.GetUserList();
        }

        public UserModel GetUserListById(string userId)
        {
            return userDataController.GetUserListById(userId);
        }

        public UserModel LoginUser(UserModel userModel)
        {
           // string password=  EncryptionUtility.DecryptCipherTextToPlainText(userModel.Password, "posadmin@123");
            return userDataController.GetUserByUserNameAndPassword(userModel.UserName,userModel.Password);
        }

        public bool SaveUser(UserModel userModel)
        {
           
            return userDataController.SaveUser(userModel);
        }

        public bool UpdateUser(UserModel userModel)
        {
            return userDataController.UpdateUser(userModel);
        }
    }
}
