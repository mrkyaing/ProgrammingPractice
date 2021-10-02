using System;
class NestedIfDemo2{
    static void Main(){
        Console.WriteLine("Bank Withdraw Process Program");
        string username="susu";
        string password="123456";
        int balance=6000;
        if(username=="susu" && password=="654321"){
           Console.WriteLine("Hello,"+username+"welcome to program.");
           int withdrawAmt=2000;
           balance-=withdrawAmt;
           Console.WriteLine("Take receive ");
        }
        else if(balance>1000){
             Console.WriteLine("unsuffcient balance to withdraw.");
        }else{
            Console.WriteLine("Invalid User");
        }
        Console.WriteLine("Your final balance is "+balance);
        Console.WriteLine("Stop Program")
    }
}