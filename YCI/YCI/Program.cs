using System;
using System.Collections;

namespace YCI
{
     class Program
    {
        static void Main(string[] args)
        {     
            Console.WriteLine("Hi");
            
            Dog dog=new Dog();
            dog.Name = "picky";
            dog.Color = "black";
            dog.Livingplace = "my house";
            dog.Eat();//picky is eating .
            dog.Sleep();//picky is sleeping.
            dog.Walk();//picky is walking.
            dog.Sound();//Woak.

            Cat cat=new Cat();
            cat.Name = "puccy";
            cat.Color = "red";
            cat.Livingplace = "your house";
            cat.Eat();
            cat.Sleep();
            cat.Walk();
            cat.Sound();

            SmartPhone iphone=new SmartPhone();
            iphone.Color = "black";
            iphone.MandeBy = "apple";
            iphone.ManufacturedDate =Convert.ToDateTime("10-12-2019");
            iphone.Type = "single sim";
            iphone.PowerOn();
            iphone.PowerOff();
            iphone.UseMobileData();
            iphone.MakeDial();
            iphone.TakeCamera("image");
            iphone.ShowSpecification();
            SmartPhone sony = new SmartPhone()
            {
                Color="blue",
                MandeBy="Sony",
                ManufacturedDate=Convert.ToDateTime("12-10-2020"),
                Type="dual sim"
            };
            sony.SendSMS();
            sony.MakeDial();
            sony.TakeCamera("video");
            sony.ShowSpecification();
            
            Lion lion = new Lion();
            lion.Color = "blue";
            lion.Name = "kathayar";
            lion.Eat();//kathayar lion eal meal.
            lion.DisplayAnimalInfo();

            Cat yourcat = new Cat();
            yourcat.Name = "juccy";
            yourcat.Eat();//juccy is eating .
            yourcat.DisplayAnimalInfo();
            
            Cow cow = new Cow();
            cow.Name = "junny";
            cow.Color = "white";
            cow.Livingplace = "forest";
            cow.Eat();
            cow.Sleep();
            cow.Walk();
            cow.DisplayAnimalInfo();
            foreach (Card c in Card.allSpades)
                Console.WriteLine(c);        
            Console.WriteLine("Press any key to close this window");
            Console.ReadKey();
        }
    }
}
