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

            CRUDOperationsForUser cruduser=new CRUDOperationsForUser();//create instance of CRUDOperationsForUser class (also called Object )
                        
            int choice=0;
            Console.Write ("choice actions: 1:(create),2:(reterive),3:(update),4:(delete):");
            choice =Convert.ToInt32( Console.ReadLine());
           
            switch (choice)
            {
                case 1: {
                        cruduser.GetUserList();
                        UserModel userModel = GetUserInput();//getting user's input from method 
                        cruduser.SaveUser(userModel);//saving data to the database with userModel Object 
                        break; 
                        }
                case 2: cruduser.GetUserList(); break;//method call to get all of user list              
                
                case 3:
                    {
                        cruduser.GetUserList();
                        UserModel userModel = GetUserInput();//getting user's input from method 
                        cruduser.UpdateUser(userModel);//update user with user model object 
                        break;
                    }
                case 4:
                    {
                        cruduser.GetUserList();
                        Console.Write("type user id to delete");
                        int userId=Convert.ToInt32(Console.ReadLine());
                        cruduser.DeleteUser(userId);//delete user by id
                        break;
                    }
            }         
            Console.WriteLine("press any key to close this window");
            Console.ReadKey(); 
        }

       private static UserModel GetUserInput()
        {
            UserModel userModel = new UserModel();

            Console.Write("Enter user Id:");
            userModel.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter user name:");
            userModel.UserName = Console.ReadLine();//read data from the keyboard input 

            Console.Write("Enter user email:");
            userModel.Email = Console.ReadLine();//read data from the keyboard input 

            Console.Write("Enter user Password:");
            userModel.Password = Console.ReadLine();//read data from the keyboard input

            return userModel;
        }
    }
}
