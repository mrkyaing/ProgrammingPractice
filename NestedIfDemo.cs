using System;
class NestedIfDemo{
    static void Main(){
        string username="susu";
        string password="zip";
        int balance=1000;
        if(username=="admin" && password=="123")
        {
            Console.WriteLine("You are administrator.");
            Console.WriteLine("You can do banking process.");
        }
        else if(username=="susu" && password=="zip")
        {
         Console.WriteLine("You are  client of bank.");
         Console.WriteLine("User Name and Password is correct.");
        }
        else if(balance>1000)
        {
             Console.WriteLine("You can withdraw from your balance.");
        }
        else
        {
         Console.WriteLine("You can't do any bank transctions");
        }
    }
}