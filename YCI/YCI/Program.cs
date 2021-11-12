using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hi");
                User user = new User()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "mgmg",
                    Email = "mgmg@gmail.com",
                    LoginedDate = DateTime.Now,
                };
                User user1 = new User();
                user1.Id = Guid.NewGuid().ToString();
                user1.Name = "Test";
                user1.Email = "Test";
                user1.LoginedDate = DateTime.Now;
                user.PrintUserInfo();
                user1.PrintUserInfo();
                Dog dog = new Dog();
                dog.Sleep();
                dog.Eat();
                dog.Bark();
                Cat cat= new Cat();
                cat.Sleep();
                cat.Eat();
                cat.Sound();
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error:{0}", e.Message);
            }
        }
    }
}
