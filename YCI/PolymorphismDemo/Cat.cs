using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Cat:Mammal
    {
        public override void Speak()
        {
            Console.WriteLine($"Meow!!,My name is {base.Name}");
        }
    }
}
