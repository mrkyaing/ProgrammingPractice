using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOperationsDemo
{
    public class WriteToTextFile
    {
        public void WriteData(string filepath,string data)
        {
            var sw=new StreamWriter(filepath);
            sw.WriteLine(data);
            sw.Close();
        }
    }
}
