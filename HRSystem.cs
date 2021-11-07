using System;
using AttendanceInfo;
using DepartmentInfo;
using StaffInfo;
namespace HR {
    class HRSystem {
        public static void Main () {
            Console.WriteLine ("HR System");
            Staff staff1=new Staff();
            staff1.Id="s001";
            Console.WriteLine("Staff Id:{0}",staff1.Id);//s001
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