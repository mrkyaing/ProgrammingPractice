using System;
class StudentInfo{
    static void Main(){
      string[] studentArray=new string[11];
      for(int i=0;i<11;i++){
       Console.Write("Enter Student "+(i+1)+" Name :");
      studentArray[i]=Console.ReadLine();
      }
     Console.WriteLine("student information Here");
     for(int i=0;i<11;i++){
         if(i==10){//checking array reach last room 
          Console.Write(studentArray[i]);
         }else
         {
            Console.Write(studentArray[i]+",");//
         }
     }
    }
}