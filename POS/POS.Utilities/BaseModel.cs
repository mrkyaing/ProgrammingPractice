using System;
using System.ComponentModel;


namespace POS.Utilities
{
    public class BaseModel
    {
        public string Id { get; set; }
        //built-in field
        //The below property will  not be visible in Datagridview or in properties window
        [Browsable(false)]
        public bool IsDelete { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }
        //The below property will  not be visible in Datagridview or in properties window
        [Browsable(false)]
        public byte[] Vesion { get; set; }
    }
}
