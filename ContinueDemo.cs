using System;
class ContinueDemo
{
    static void Main()
    {
        for(int i=1;i<=10;i++)
        {
            int result=i%2;//1,0 
            if(result!=0){
                continue;
            }
            Console.Write(i+" ");//2  4  6  8  10 
        }
    }
}