using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAO
{
    public interface IUserDAO
    {
      UserModel GetUserListByUserNameAndPassword(string UserName, string Password);
    }
}
