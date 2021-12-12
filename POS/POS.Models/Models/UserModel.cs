using POS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models
{
    public class UserModel:BaseModel
    {       
        public string UserName { get; set; }
        public string Email { get; set; }
        //The below property will  not be visible in Datagridview or in properties window
        [Browsable(false)]
        public string Password { get; set; }
    }
}
