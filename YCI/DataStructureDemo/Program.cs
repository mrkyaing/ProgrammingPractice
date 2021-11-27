using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you need to import >>using System.Collections;
            ArrayList myData = new ArrayList();//Crete object of ArrayList
            myData.Add("Su Su");//will add 0 array of index 
            myData.Add("Mg Mg");//will add 1 array of index
            myData.Add("Zaw Zaw");
            myData.Add("Aye Aye");
            myData.Remove(0);//remove data by the usage of array index 0
            //myData.Remove(7);//will occur ArrayIndeeOutOfBound Error  
            myData.Remove("Zaw Zaw Aung");//remove data by the usage of value 
            myData.Sort();
            //syntax of foreach loop
            //foreach(itemtype variableName in collecitonName)

            foreach (string data in myData)
            {
                Console.WriteLine(data);//Aye Aye,
                                        //Mg Mg ,Su Su, Zaw Zaw 
            }

            ArrayList numbers = new ArrayList();
            numbers.Add(-10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(50);
            numbers.Add(300);
            numbers.Sort();
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            ArrayList allOfData = new ArrayList();
            allOfData.Add("Yangon");
            allOfData.Add(true);
            allOfData.Add(200);
            allOfData.Add(DateTime.Now);
            allOfData.Remove(0);
            //var is keyword and it is implict data type in C#.
            foreach (var v in allOfData)
            {
                Console.WriteLine(v);
            }


            //you need to import >>using System.Collections.Generic;
            //int[] ok = new int[10];
            IList<int> examList = new List<int>();
            examList.Add(40);
            examList.Add(50);
            examList.Add(60);
            examList.Remove(0);
            //examList.Add("mgmg");// sematic error 
            foreach (var v in examList)
            {
                Console.WriteLine(v);
            }
            List<string> nameList = new List<string>();
            nameList.Add("U Mya");
            nameList.Add("Daw Hla");
            foreach (var v in nameList)
            {
                Console.WriteLine(v);
            }

            Stack fbSearch = new Stack();
            fbSearch.Push("New Year Sale in Yangon");//2
            fbSearch.Push("New Year Sale in Mandalay");//1
            fbSearch.Push("What is happing in US?");//0
           
            try { 
                while(fbSearch.Count>0)
                {
                   Console.WriteLine(fbSearch.Peek());//>>What is happing in US?
                   fbSearch.Pop();
                }
             }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("press any key to close this window");
            Console.ReadLine();
        }
    }
}
