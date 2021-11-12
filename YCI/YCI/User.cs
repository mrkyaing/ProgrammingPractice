using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    public class User
    {
        private string _id, _name, _email, _password;
        private DateTime _loginedDate;
        public string Id
        {
            get { return _id; }
            set {
                if (string.IsNullOrEmpty(value)) 
                { throw new ArgumentNullException("id value is invalid!"); }
                _id = value; 
            }
        }
        public string Name { get { return _name;} set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name value is invalid!");
                }
                _name = value; 
            } 
        }
        public DateTime LoginedDate { get { return _loginedDate; }
        set { _loginedDate = value; }
        }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
    public void PrintUserInfo()
        {
            Console.WriteLine($"id{_id}");
        }
    }
}
