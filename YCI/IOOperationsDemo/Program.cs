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

                string brfilepath = @"E:\\me.dat";
                BinaryWriter(brfilepath);
                BinaryReader(brfilepath);
                GetFileInfo();
                string copyfilepath = @"E:\\youani.txt";
                CopyMyFile(filepath, copyfilepath);
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
            Console.WriteLine("Press any kay to close this window");
            Console.ReadKey();
        }
        public  static void BinaryWriter(string filepath)
        {
            using(BinaryWriter bw=new BinaryWriter(File.Open(filepath, FileMode.Create)))
            {
                bw.Write(2.3);                
            }
        }
        static void BinaryReader(string filepath)
        {
            using (BinaryReader br = new BinaryReader(File.Open(filepath, FileMode.Open)))
            {
                Console.WriteLine(br.ReadDouble());
            }
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

        public static void CopyMyFile(string frompath,string topath)
        {
            File.Copy(frompath, topath);
        }

        public static void GetFileInfo()
        {
            FileInfo info = new FileInfo(@"E:\\ProjectOne.approj");
            FileAttributes attributes = info.Attributes;
            DateTime time = info.CreationTime;
            Console.WriteLine($"file attribute:{attributes}");
            Console.WriteLine($"file created Time:{time}");
            time = info.LastAccessTime;
            Console.WriteLine($"file last access Time:{time}");
            Console.WriteLine($"file name:{info.Name}");
            Console.WriteLine($"file size:{info.Length} byte");
            info = new FileInfo(@"C:\\");
            attributes = info.Attributes;
            Console.WriteLine(attributes);
        }

    }
}
