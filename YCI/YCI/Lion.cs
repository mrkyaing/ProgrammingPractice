using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    public class Lion:Animal
    {
        //base keyword(C#) is used to access(read/write) all members/methods  of  parent class.
        //super keyword in Java
        public override void Eat()
        {
            Console.WriteLine("{0} lion eat meal",base.Name);
        }
        
    }
}
