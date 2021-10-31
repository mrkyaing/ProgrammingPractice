using System;
using StudentInfo;//import / call 
using TeacherInfo;//import /call 
namespace SchoolMgtSystemInfo{
    class SchooolMgtSystem{
        static void Main(){
            Console.WriteLine("Program start");
            Student.ShowInfo();//Hi,I am a student from StudentInfo Namespace.
            Teacher.ShowInfo();//Hi,I am a teacher from TeacherInfo Namespace.
            Console.WriteLine("Program stop");
        }//end of Main
    }//end of class 
}//end namespace 