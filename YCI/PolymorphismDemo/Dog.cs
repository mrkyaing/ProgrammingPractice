using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Dog:Mammal
    {
        public override void Speak()
        {
            Console.WriteLine($"Woak!!,My name is {base.Name}");
        }
    }
}
