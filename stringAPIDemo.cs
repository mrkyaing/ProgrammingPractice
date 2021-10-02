using System;//call or import System Library
class stringAPIDemo{
    static void Main(){ //start Main Method Here
        //char value="Hello,how are you?";//sematic error 
        string message="Hello,How are you?";
        Console.WriteLine("Your message length is "+message.Length);//18
        Console.WriteLine("The Index of charactor y is "+message.IndexOf('y'));//14 (index value is start from 0)
        Console.WriteLine("Your message are changing to Upper Case is "+message.ToUpper());
        string message2="Nice to See You!!";
        Console.WriteLine("Lower Case Letter of message 2 "+message2.ToLower());//nice to see you!
        string message3=message+message2;//message and message2 are combined as message 3
        Console.WriteLine("Final message is "+message3);
        Console.WriteLine("your clone message is "+ message.Clone());//Hello,How are you?
        // message==message2;
        Console.WriteLine("two string compare result is "+message.CompareTo(message2));//if two string are equal 0,else -1
    }//end of Main Method 
}//end of class 