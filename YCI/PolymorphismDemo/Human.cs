using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Human : Mammal
    {
        public string BloodType { get; set; }
        public string NRC { get; set; }

        public override void Speak()
        {
            Console.WriteLine($"Hi,My name is {base.Name}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Blob Type:{BloodType}");
            Console.WriteLine($"National Registration Card Id:{NRC}");
        }
    }
}
