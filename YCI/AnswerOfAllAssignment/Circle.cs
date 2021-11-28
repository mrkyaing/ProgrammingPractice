using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerOfAllAssignment
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public override void CalculateArea()
        {
            double result = 3.14 * Radius * Radius;
            Console.WriteLine($"Area Of Circle {result}");
        }

        public override void CalculatePerimeter()
        {
            double result =2* 3.14 * Radius;
            Console.WriteLine($"Area Of Preimeter {result}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Radius:{Radius}");
        }
    }
}
