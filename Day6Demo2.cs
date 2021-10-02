using System;
class Day6Demo2{
    static void Main(){
       int x=10;
       int y=2;
       //int result=10+"Hello"; //sematic Error will occur 
        Console.WriteLine("Checking Relational Operator Here.");
       Console.WriteLine("x==y ?"+ (x==y) );//False (+ represnet string(text) concasting process)
       Console.WriteLine("x>y ?"+ (x>y) );//True
       int z=10;
       Console.WriteLine("x>=z ?"+ (x>=z) );// True
       Console.WriteLine("x!=y ? "+ (x!=y) );//True
      
       Console.WriteLine("Checking Logical Operator Here.");
       Console.WriteLine("x>y or x>z ?" +(x>y || x>z));//True
       Console.WriteLine("x<y or x>z ?" +(x<y || x>z));//False
       Console.WriteLine("x>y AND x>z ?" +(x>y && x>z));//False 
       Console.WriteLine("x<y AND x>z ?" +(x<y && x>z));//False 
       Console.WriteLine("x<y AND x>z ?" +(!(x<y && x>z)));//Ture 
    }
}