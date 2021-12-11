using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Utilities
{
    public static class AuditUser
    {

        //for delete or update actions 
        public static string Id { get; set; }
        //for aduit user id action
        public static string UserId { get; set; }
        public static string UserName { get; set; }
    }
}
