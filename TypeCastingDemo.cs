using System;
class TypeCastingDemo{
    static void Main()
    {
        int i=10;
        double d=i;
        Console.WriteLine("i valuie is "+i);//10
        Console.WriteLine("d value is "+d);//10.0
        double value1=9.8;
        int result=(int)value1;//Type Casting from double to int 
        Console.WriteLine("value1 is "+value1);
        Console.WriteLine("reuslt is "+result);
        float f=result;//int to float (automatically type casting )
        string data="20";
        int age=Convert.ToInt32(data);//20
        int result1=30-age;//10
        Console.WriteLine("final result is "+result1);//10
    }
}