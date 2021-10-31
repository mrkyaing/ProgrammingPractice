using System;
class TryCatchDemo{
    static void Main(){
        //  Here:
        try{
            Console.Write("Enter number of values     :");
            int numberOfValue=Convert.ToInt32(Console.ReadLine());//7
            string[] names=new string[numberOfValue];  
            for(int i=0;i<numberOfValue;i++){
             Console.Write("Enter values     :");
                names[i]=Console.ReadLine();
        }//end of for 
        Console.WriteLine("Your Entering Name are:");
          for(int i=0;i<numberOfValue;i++){
              Console.WriteLine(names[i]);
        }//end of for       
        }//end of try
        catch(Exception e){
         Console.WriteLine("Hay Plz Type Number Only when you define Values! Try Again");
        // goto Here;
        }          
    }
}