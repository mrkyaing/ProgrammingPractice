using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerOfAllAssignment
{
    public  abstract class Shape
    {
        public string Color { get; set; }
        public bool  IsFilled { get; set; }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Is Filled :{IsFilled}");
        }
    }
}
