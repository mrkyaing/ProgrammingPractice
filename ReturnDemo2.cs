using System;
class ReturnDemo2
{
    static void Main()
    {
        int i=1;
        int total=0;
        while(i<=10000){
            total+=i;//1
            i++;//2
            Console.WriteLine("Total is "+total);//1
            return;
            //1
            //3
            //6
            //10
            //15
            //21
            //27
            //28
            //36
            //45
            //55

        }     
    }
}