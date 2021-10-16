using System;
class ContinueDemo2
{
    static void Main()
    {
     for(int i=10;i>0;i--)
     {
         if(i==5 || i==2){
             continue;
         }
         Console.Write(i+" ");//10 9 8 7 6  4 3  1 
     }
    }
}