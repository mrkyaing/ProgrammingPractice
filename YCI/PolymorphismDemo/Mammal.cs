using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Mammal
    {
        //data members of Mammal
        public string Name { get; set; }
        public string Color { get; set; }
        public int LifeSpan { get; set; }
        public string EatFoodType { get; set; }
        //behaviors 
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} is speaking.");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"LifeSpan:{LifeSpan}");
            Console.WriteLine($"Eaten Food Type:{EatFoodType}");
        }
    }
}
