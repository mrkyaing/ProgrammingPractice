using System;
namespace YCI
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("eating");
        }
        public  void Sleep()
        {
            Console.WriteLine("sleeping");
        }
        public virtual void Sound() 
        { 
            Console.WriteLine("speaking"); 
        }
        public void Walk()
        {
            Console.WriteLine("walking!");
        }
    }
}
