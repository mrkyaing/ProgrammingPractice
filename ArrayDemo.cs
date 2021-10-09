using System;
class ArrayDemo
{
    static void Main(){
        int[] numbers ;//declare int array
        numbers=new int[10];//allocate array to the Memory (RAM)

        char[] alpherbard;//declare char array
        alpherbard=new char[3];
        alpherbard[0]='A';//write data to the declared array 
        alpherbard[1]='B';
        alpherbard[2]='C';

        string[] sms=new string[10];
        sms[0]="Hi";
        sms[1]="How are you?";
    }
}