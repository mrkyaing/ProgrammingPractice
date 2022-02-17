using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVCProject.Models
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public AddressModel HomeAddress { get; set; }
    }
}