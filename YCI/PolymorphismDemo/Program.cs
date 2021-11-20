using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            //compile time polymorphism 
            Calculator calculator = new Calculator();
            calculator.Add(1, 2);
            calculator.Add(1, 2, 3);
            calculator.Add(2.3, 9.5);
            //runtime polymorphism
            Human human = new Human()
            {
                Name = "Su Su",
                Color="white",
                LifeSpan=100,
                EatFoodType="meals and fruits",
                BloodType="A",
                NRC="9/balala(N)120592"
            };
            human.DisplayInfo();
            human.Sleep();
            human.Eat();
            human.Speak();
            
            Dog dog = new Dog()
            {
                Name = "Jacky",
                Color = "white",
                LifeSpan = 10,
                EatFoodType = "meals",
            };
            dog.DisplayInfo();
            dog.Sleep();
            dog.Eat();
            dog.Speak();

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
