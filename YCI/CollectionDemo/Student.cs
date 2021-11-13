using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void PrintStudentInfo(IList<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Student Id :{student.Id}");
                Console.WriteLine($"Student Name :{student.Name}");              
            }
        }

        public void PrintStudentInfo()
        {          
               Console.WriteLine($"Student Id :{Id}");
               Console.WriteLine($"Student Name :{Name}");
        }
    }
}
