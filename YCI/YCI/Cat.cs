using System;
namespace YCI
{
    public class Cat:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("eating meal");
        }
        public override void Sound()
        {
            Console.WriteLine("Meow.Meow..Meow...");
        }
    }
}
