using System;
class DoWhileLoopDemo{
    static void Main(){
        int i=1;
      do{
            if(i%2 == 0)
            {
                Console.WriteLine(i+" is Even.");
            }
       i++;
      }while(i<=100);
    }
}