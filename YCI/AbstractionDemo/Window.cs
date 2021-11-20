using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public abstract class Window
    {
        //data members
        public string Title { get; set; }
        public int Width { get; set; }
        public int  Height { get; set; }
        
        //behaviors
        //non-abstract method 
        public void DiaplayInfo()
        {
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Width:" + Width);
            Console.WriteLine("Height:" + Height);
        }
        //abstract method (only has method signature,do not has implementation/method body)
        //tell what ,not tell how 
        public abstract void Close();
        public abstract void Open();
    }
}
