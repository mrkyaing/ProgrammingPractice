using System;
class GotoDemo
{
    static void Main()
    {
        int num=60;
        switch(num)
        {
            case 5:Console.WriteLine("this is case 5");break;
            case 10:Console.WriteLine("this is case 10");break;
            case 20: goto case 5;
            default:Console.WriteLine("invalid value");break;
        }
    }
}