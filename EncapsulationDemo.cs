using System;
using ComputerFactory;
namespace Demo {
    class EncapsulationDemo {
       public static void Main () {
           try
           {
            Console.WriteLine ("Program start");
            Computer myPC = new Computer ();
           // myPC.cpu = "core i5";// direct access error>> cause of encapulation 
            myPC.SetCPU("core i7");
            myPC.SetRAM("16GB");
            myPC.SetStorage("256SSD");
            myPC.SetGPU("2GB");
            myPC.DisplayInfo ();
            Computer yourPC = new Computer ();
            yourPC.SetCPU("core i3");
            yourPC.SetRAM("2GB");
            yourPC.SetStorage("512SSD");
            yourPC.SetGPU("2GB");
            yourPC.DisplayInfo ();
            Console.WriteLine("your cpu is"+yourPC.GetCPU());//core i3
            Console.WriteLine ("Program stop");
           }
           catch (Exception e)
           {
               Console.WriteLine("error occur cause of "+e.Message);
           }
        }
    }
}
namespace ComputerFactory {
  public  class Computer {
      //encapsulate members
        private string cpu, ram, storage, gpu;
       //set cpu value with SetCPU Method
       public void SetCPU(string _cpu){
           if(string.IsNullOrEmpty(_cpu)){
               throw new ArgumentException("invalid cpu value.");
           }
           cpu=_cpu;
       }
       //get cpu value with GetCPU Method 
        public string GetCPU(){
           return cpu;
       }
       public void SetRAM(string _ram){
            if(string.IsNullOrEmpty(_ram)){
               throw new ArgumentException("invalid ram value.");
           }
           ram=_ram;
       }
       public void SetStorage(string _storage){
            if(string.IsNullOrEmpty(_storage)){
               throw new ArgumentException("invalid _storage value.");
           }
           storage=_storage;
       }
    public void SetGPU(string _gpu){
         if(string.IsNullOrEmpty(_gpu)){
               throw new ArgumentException("invalid _gpu value.");
           }
           gpu=_gpu;
       }
      
        public void DisplayInfo () {
            Console.WriteLine ("Computer Specification");
            Console.WriteLine ("CPU:{0}", cpu);
            Console.WriteLine ("RAM:{0}", ram);
            Console.WriteLine ("Storage:{0}", storage);
            Console.WriteLine ("GPU:{0}", gpu);
        }
    }
}