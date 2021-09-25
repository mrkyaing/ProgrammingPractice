using System;
class DataTypeDemo{
    static void Main(){
        byte b=23;
        short s=555;
        int i=700;
        long l=80000;
        Console.WriteLine("byte value is "+b);// byte value is 23
        Console.WriteLine("my short value is "+s);//my short value is 5555
        Console.WriteLine(i);//700
        Console.WriteLine(l);//80000
        float f=2.5F;
        double d=f-1.5;
        decimal d1=80.9M;
        Console.WriteLine("float value is "+ f);//2.5
        Console.WriteLine("double value is "+d);//1
        Console.WriteLine("decimal value is "+d1);//80.9
        bool myvalue=true;
       // bool myvalue2=10;//sematic error 
        char ok='A';
        Console.WriteLine("my bool value is "+myvalue);//true
        Console.WriteLine("my charactor value is "+ok);//A
    }//end of Main Method 
}// end of class 