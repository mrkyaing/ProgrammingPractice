using System;
using AttendanceInfo;
using DepartmentInfo;
using StaffInfo;
namespace HR {
    class HRSystem {
        public static void Main () {
            try
            {
            Console.WriteLine ("HR System");
            Staff staff1=new Staff();
            staff1.Id="s001";
            staff1.Age=30;
            Console.WriteLine("Staff Id:{0}",staff1.Id);//s001
            Console.WriteLine("Staff Age:{0}",staff1.Age);//30
             Staff staff2=new Staff();
            staff1.Id="s002";
            staff1.Age=-10;
            Console.WriteLine("Staff Id:{0}",staff1.Id);//s001
            Console.WriteLine("Staff Age:{0}",staff1.Age);//30
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry error occur");
                Console.WriteLine("Error Message:"+e.Message);
            }
        }
    }
}
namespace StaffInfo {
    public class Staff {
        private string id, name, email, phone;
        private int age;
        private DateTime joinedDate;
        //a property to get/set id value 
        public string Id {
            get {
                return id;
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException ("ivalid staff id");
                }
                id = value;
            }
        }
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public int Age{
            get{
             return age;
            }
            set{
              if(value<0){
             throw new ArgumentException("invalid age value");
              }
              age=value;
            }
        }
    }
}
namespace DepartmentInfo {
    public class Department {
        private string id, name, reportTo;
    }
}
namespace AttendanceInfo {
    public class Attendance {
        private DateTime arrivialTime, departureTime;
    }
}