using System;
class ArrayDemo
{
    static void Main(){
        int[] myarray=new int[10];
         myarray[0]=7;//writing to array 
        // Console.WriteLine(myarray[5]);//0 >>reading from array 
        //Console.WriteLine(myarray[0]);//7 >>reading from array 
       for(int i=0;i<10;i++){
           //i will reprsent as Index of Array 
           Console.Write(myarray[i]+" ");//7 0 0 0 0 0 0 0 0 0
       }
       Console.WriteLine();
       bool[] ok=new bool[5];//declare bool type array 
       ok[1]=true;
       for(int i=0;i<5;i++)
       {
           Console.Write(ok[i]+" ");//False True False False False
       }
        Console.WriteLine();
       string[] sms=new string[10];//array size or length 10
       sms[0]="Are You Busy?";//write to array 
       sms[1]="Calll Me Back";
       sms[2]="On The Way";
        for(int i=0;i<10;i++){
            Console.WriteLine(sms[i]);//read from array 
        }
        char[] mychar=new char[5];
        mychar[0]='A';
        mychar[1]='z';
         for(int i=0;i<5;i++){
            Console.WriteLine(mychar[i]);//read from array 
        }
    }

}