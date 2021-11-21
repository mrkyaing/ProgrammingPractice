using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class Staff:IShowDetailInfo
    {
        public string StaffId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public double BaseSalary { get; set; }
        public DateTime JoinedDate { get; set; }
       
        public void ShowDetailInfo()
        {
            Console.WriteLine($"Staff Id:{StaffId}");
            Console.WriteLine($"Staff Name:{Name}");
            Console.WriteLine($"Staff Email:{Email}");
            Console.WriteLine($"Staff Phone:{Phone}");
            Console.WriteLine($"Staff Positon:{Position}");
            Console.WriteLine($"Staff Department:{Department}");
            Console.WriteLine($"Staff Base Salary:{BaseSalary}");
            Console.WriteLine($"Staff Joined Date:{JoinedDate}");
            //2021 -2019
            Console.WriteLine($"Staff Service Year(s):{DateTime.Now.Year-JoinedDate.Year}");
        }
    }
}
