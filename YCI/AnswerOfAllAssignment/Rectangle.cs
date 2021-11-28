using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerOfAllAssignment
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override void CalculateArea()
        {
            double result = Width * Height;
            Console.WriteLine($"Area Of Rectangle {result}");
        }

        public override void CalculatePerimeter()
        {
            double result = (Width + Height)*2;
            Console.WriteLine($"Perimeter Of Rectangle {result}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Width:{Width}");
            Console.WriteLine($"Height:{Height}");
        }
    }
}
