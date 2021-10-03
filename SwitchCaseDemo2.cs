using System;

    public class SwitchCaseDemo2
    {
        public static void Main()
        {

        int i = 10, j = 30;

        char myvalue = 'a',value='s';

        switch (myvalue)//one decision
        {
            //more than 3 multiple condtion 
            case 'A':Console.WriteLine("vowel");break;
            case 'E': Console.WriteLine("vowel"); break;
            case 'I': Console.WriteLine("vowel"); break;
            case 'O': Console.WriteLine("vowel"); break;
            case 'U': Console.WriteLine("vowel"); break;
            case 'a': Console.WriteLine("vowel"); break;
            case 'e': Console.WriteLine("vowel"); break;
            case 'i': Console.WriteLine("vowel"); break;
            case 'o': Console.WriteLine("vowel"); break;
            case 'u': Console.WriteLine("vowel"); break;
            default:Console.WriteLine(myvalue + " is not vowel");break;
        }
        }
    }

