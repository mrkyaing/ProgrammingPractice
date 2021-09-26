using System;//call or import System Library
class stringAPIDemo{
    static void Main(){ //start Main Method Here
        string message="Hello,How are you?";
        Console.WriteLine("Your message length is "+message.Length);
        Console.WriteLine("The Index of charactor H is "+message.IndexOf('H'));
        Console.WriteLine("Your message are changing to Upper Case is "+message.ToUpper());
        string message2="Nice to see you!";
        string message3=message+message2;//message and message2 are combined as message 3
        Console.WriteLine("Final message is "+message3);
    }//end of Main Method 
}//end of class 