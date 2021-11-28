using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerOfAllAssignment
{
    public abstract class Staff
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }
        public string Address { get; set; }
        public abstract void CalcualtePayroll();
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Staff Id:{Id}");
            Console.WriteLine($"Staff Name:{Name}");
            Console.WriteLine($"Staff Address:{Address}");
            Console.WriteLine($"Staff Age:{Age}");

        }
    }
}
