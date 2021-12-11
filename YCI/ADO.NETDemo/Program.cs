using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.CheckDatabaseConnection();

            CRUDOperationsForUser cruduser=new CRUDOperationsForUser();
            cruduser.GetUserList();//method call
            
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
