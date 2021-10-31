using System;
using StudentInfo; //import / call StudentInfo namespace
using TeacherInfo; //import /call  TeacherInfo namespace 
namespace SchoolMgtSystemInfo{
    class SchooolMgtSystem{
        static void Main(){
            Console.WriteLine("Program start");
            Student.ShowInfo(); //Hi,I am a student from StudentInfo Namespace.
            Teacher.ShowInfo(); //Hi,I am a teacher from TeacherInfo Namespace.
            Console.WriteLine("Program stop");
        } //end of Main
    } //end of class 
} //end namespace 
namespace StudentInfo{
    //define Student class  as Prototype/BluePrint/Template 
    class Student{
        public static void ShowInfo(){
            Console.WriteLine ("Hi,I am a student from StudentInfo Namespace.");
        } //end of ShowInfo method 
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