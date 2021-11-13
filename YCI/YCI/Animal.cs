using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    public class Animal
    {
        private string name, color, livingplace;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Livingplace { 
            get { return livingplace; }
            set { livingplace = value; }
        }
        public void Eat()
        {
            Console.WriteLine("{0} is eating.", name);
        }
        public void Sleep()
        {
            Console.WriteLine("{0} is sleeping.", name);
        }
        public void Walk()
        {
            Console.WriteLine("{0} is walking.", name);
        }
    }
}
