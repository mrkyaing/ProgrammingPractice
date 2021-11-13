using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCI
{
    public class ElectronicDevice
    {
        //type,manufacturedate,color,madedby
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private DateTime manufacturedDate;

        public DateTime ManufacturedDate
        {
            get { return manufacturedDate; }
            set { manufacturedDate = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private string madeBy;

        public string MandeBy
        {
            get { return madeBy; }
            set { madeBy = value; }
        }
        public void PowerOn()
        {
            Console.WriteLine("power on");
        }
        public void PowerOff()
        {
            Console.WriteLine("power Off");
        }

        public void ShowSpecification()
        {
            Console.WriteLine("Color:{0}", color);
            Console.WriteLine("Type:{0}", type);
            Console.WriteLine("MadeBy:{0}",madeBy);
            Console.WriteLine("Manufactued Date:{0}", manufacturedDate);
        }
    }
}
