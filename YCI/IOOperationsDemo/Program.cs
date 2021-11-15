using System;
using System.IO;

namespace IOOperationsDemo
{
    internal class Program
    {
        public static string filePaht=@"E:\help.txt";// E:\\help.txt
        public static string filepath = @"E:\demo.txt";
        static void Main(string[] args)
        {
            StreamReader data = null;
            try
            {
                data = new StreamReader(filePaht);
                while (data.Peek() >= 0)
                {
                    Console.WriteLine(data.ReadLine());
                }
               WriteToTextFile writeToTextFile=new WriteToTextFile();
               writeToTextFile.WriteData(filepath, "Hi,today is " + DateTime.Now.ToString());
               ReadDirectoryInfo(@"C:\");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error occur when file read:{e.Message}");
            }
            finally
            {
                if (data != null)
                 data.Close();
            }
            Console.ReadKey();
        }

        public static void ReadDirectoryInfo(string path)
        {
            var dirinfo=new DirectoryInfo(path);
            var dirList= dirinfo.GetDirectories();
            foreach(var dir in dirList)
            {
                Console.WriteLine(dir.Name);
            }
            var fileList=dirinfo.GetFiles();
            foreach(var file in fileList)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
