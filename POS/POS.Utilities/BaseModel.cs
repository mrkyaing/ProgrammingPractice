using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Utilities
{
    public class BaseModel
    {

        public string Id { get; set; } 
        //built-in field
        public bool IsDelete { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string DeletedUserId { get; set; }
        public byte[] Vesion { get; set; }
    }
}
