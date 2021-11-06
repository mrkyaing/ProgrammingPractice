using System;
using CarInfo;
namespace VehicleInfo
{
    class VehicleMgtSystem{
      public static void Main(){
      Car myCar=new Car();//Create a car Object 
      myCar.speed=30;
      myCar.color="Black";
      myCar.licenceNo="BG-001";
      myCar.DisplayCarInfo();
      myCar.StartEngine();
      myCar.Drive();
      myCar.StopEngine();
      Console.WriteLine("=====================");
      Car yourCar=new Car();//create Car Object by providing of Constructor
      yourCar.DisplayCarInfo();
      Engine engine=new Engine();//create engine 
      engine.enginePower="5hp";
      engine.numberOfPinion=50;
      engine.modedBy="India";
      engine.DisplayEngineInfo();
      Circle c1=new Circle();//create the object by the no-paremeter/argument
      c1.SetRadius(2.2);
      double resultArea= c1.GetArea();//3.14*2.2*2.2
      Console.WriteLine("Area of Circle c1:"+resultArea);//
      Circle c2=new Circle(3.3);//create the object with 1 argument/paremetner
      double resultArea2= c2.GetArea();//3.14*3.3*3.3
      double resultperimeter=c2.GetPerimeter();//3.14*2*3.3
      Console.WriteLine("Area of Circle c2:"+resultArea2);//
      }
    }
}
namespace CarInfo{
    class Car{
        //3 states 
      public  int speed;
      public string licenceNo,color;
        //1 Constructor(same name of Class)
        public Car(){
            speed=0;
            licenceNo="no licence ";
            color="no color ";
        }
        //3 behaviors
        public void StartEngine(){
            Console.WriteLine("start engine");
        }
        public void StopEngine(){
        Console.WriteLine("stop engine");
        }
        public void Drive(){
        Console.WriteLine("Drive the Car");
        }
        public void DisplayCarInfo(){
            Console.WriteLine("Color:{0}",color);
            Console.WriteLine("LicenceNo:{0}",licenceNo);
            Console.WriteLine("Speed:{0}",speed);
        }
    }
    class Engine{
        //3 states
        public string enginePower;
        public int numberOfPinion;
        public string modedBy;
        //1 behavior/action/method
        public void DisplayEngineInfo(){
            Console.WriteLine("enginePower:{0}",enginePower);
            Console.WriteLine("numberOfPinion:{0}",numberOfPinion);
            Console.WriteLine("modedBy:{0}",modedBy);
        }
    }
class Circle{
    //1 states
    public double radius;
    //2 constructors
    //no-argument/paremeter
    public Circle(){
    }
     //1 argument/paremeter
    public Circle(double newRadius){
        radius=newRadius;
    }
    //3 behaviors
    public double GetArea(){
        double result=Math.PI*radius*radius;
        return result;
    }
    public double GetPerimeter(){
        double result=2*Math.PI*radius;
        return result;
    }
    //to set the radious vlaue from the created Object 
    public void SetRadius(double newRadius){
        radius=newRadius;
    }
}
}