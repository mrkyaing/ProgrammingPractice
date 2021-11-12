using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    public class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("eat meal and fruit");
        }
        public override void Sound()
        {
            Console.WriteLine("Woak.Woak..Woak...");
        }
        public void Bark()
        {
            Console.WriteLine("bark stranger");
        }
    }
}
