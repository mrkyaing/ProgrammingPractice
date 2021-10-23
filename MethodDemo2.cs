using System;
class MethodDemo2{
    static void Main(){
        Console.Write("Enter a text:");
        string data=Console.ReadLine();//hi
        int result=CountVowelInString(data);//method call/invoke with 1 string paremeter 
        Console.WriteLine("vowel count is:"+result);
    }

    //define a method 
  static int CountVowelInString(string inputdata){//hi
        int count=0;
        char[] myvalue=inputdata.ToCharArray();
        for(int i=0;i<myvalue.Length;i++){
            switch(myvalue[i]){
                case 'a':count++;break;
                case 'e':count++;break;
                case 'i':count++;break;
                case 'o':count++;break;
                case 'u':count++;break;
            }
        }
    return count;//1
    }
}