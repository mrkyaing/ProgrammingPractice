using System;
using StudentInfo; //import / call StudentInfo namespace
using TeacherInfo; //import /call  TeacherInfo namespace 
namespace SchoolMgtSystemInfo{
    class SchoolMgtSystem{
        static void Main(){
            Console.WriteLine("Program start");
            Student.ShowInfo(); //Hi,I am a student from StudentInfo Namespace.
            Student.SayHello("Mg Kyaing");//i am a student ,my name is Mg Kyiang
            Teacher.ShowInfo(); //Hi,I am a teacher from TeacherInfo Namespace.
            CoourseInfo.Course.DisplayCourseDetail();
            Console.WriteLine("Program stop");
        } //end of Main
    } //end of class 
} //end namespace 


namespace StudentInfo{
    //define Student class  as Prototype/BluePrint/Template 
    class Student{
        public static void ShowInfo(){
            System.Console.WriteLine ("Hi,I am a student from StudentInfo Namespace.");
        } //end of ShowInfo method 
        public static void SayHello(string yourname){
            Console.WriteLine("i am a student,my name is "+yourname);
        }
    } //end of class 
} //end of namespace 


//define TeacherInfo as namespace 
namespace TeacherInfo{
    //define Teacher class  as Prototype/BluePrint/Template 
    class Teacher{
        public static void ShowInfo(){
            Console.WriteLine ("Hi,I am a teacher from TeacherInfo Namespace.");
        } //end of show Info Method 
    } //end of class 
} //end of TeacherInfo namespace

namespace CoourseInfo{
    class Course{
        public static void DisplayCourseDetail(){
            Console.WriteLine("Course Name:C# programming Zero to Hero");
            Console.WriteLine("Course Duration:4 Months");
            Console.WriteLine("Instrocutr Name:Jonh Smith");
            Console.WriteLine("Course Fees:10$");
            Console.WriteLine("Course Start Date:"+DateTime.Now);
        }
    }
}