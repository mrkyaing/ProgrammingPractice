using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Beep();
            //non-generic collection 
            ArrayList data = new ArrayList();
            data.Add(1);// index 0
            data.Add("hi");//index 1
            data.Add(true);//
            data.Add(DateTime.Now);//datetime value
            data.Add(2.3f);//float value
            data.Add(300.5M);//decimal value
            data.Insert(2, "you and i");
            data.Remove("hi");//remove by value (hi)
            data.RemoveAt(5);//remove of index 5
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(25);
            numbers.Add(396);
            numbers.Add(3);
            numbers.Add(445);
            Console.WriteLine("original number list:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after sorting number list:");
            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Generic 
            IList<int> marks = new List<int>();
            marks.Add(60);
            marks.Add(80);
            marks.Add(90);
            IList<Student> students = new List<Student>();
            
            Student student = new Student()
            {
                Id = 1,
                Name = "Mg Mg",
                Age =15
            };
            
            Student student2 = new Student();
            student2.Id = 2;
            student2.Name = "Su su";
            student2.Age = 5;
            students.Add(student);
            students.Add(student2);
            Console.WriteLine("All Student List");
            student.PrintStudentInfo(students);
            //select * from student where age>12 and age<12 ; sql statement
            Student[] teenAgerStudentList= students.Where(s=>s.Age>12&&s.Age<20).ToArray();//linq 
            Console.WriteLine("TeenAger Student List");
            student.PrintStudentInfo(teenAgerStudentList);
            //select top 1 * from studnet where id=1;
            Student student1=students.Where(s=>s.Id==1).FirstOrDefault();
            student1.PrintStudentInfo();

            

            Console.ReadKey();
        }
    }
}
