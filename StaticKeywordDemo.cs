using System;
using Hello;
namespace Hi{
    class StaticKeyWordDemo{
        public static void Main(){
        Test t1=new Test();
        //t1.i=20;//sematic error 
        t1.x=70;
        t1.DisplayX();
        Test.DisplayI();
        }
     
    }
}

namespace Hello{
  public  class Test{
       public static int i=10;
       public int x;
       public static void DisplayI(){
        Console.WriteLine("value of i:"+i);
       }
        public  void DisplayX(){
        Console.WriteLine("value of x:"+x);
       }
    }
}
