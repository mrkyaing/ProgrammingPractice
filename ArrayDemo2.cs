using System;
class ArrayDemo2{
    static void Main(){
        double[] myArray=new double[5];//declare array 
        myArray[0]=2.3;//access(write) to array
        myArray[1]=25.9;
      for(int i=0;i<5;i++){
        //access(read) from array
        Console.Write(myArray[i]+" ");//2.3 25.9 0 0 0
      }
      Console.WriteLine("the Array Size of myArray is"+myArray.Length);//5
      char[] vowelArray={'a','e','i','o','u','E'};//array initialize the array with values
      
      //don't check like that <=vowelArray.Length .if so,u will get IndexOutOfRangeException
      for(int i=0;i<vowelArray.Length;i++){
          Console.Write(vowelArray[i]+" ");//a e i o u E
      }
      Console.WriteLine("program finished");
    }
}