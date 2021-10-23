using System;
class ExamMark{
    static void Main(){
        int[,] marksArray=new int[4,6];
        string[] studentArray=new string[4];
            //to write student name data
            for(int j=0;j<studentArray.Length;j++){//Length means to know array length/size
                Console.Write("Please Student "+(j+1)+" Name:");
                studentArray[j]=Console.ReadLine();
            }    
        //to write mark for each student
        for(int i=0;i<marksArray.GetLength(0);i++){//GetLength(0) means to know array's rows 4
            Console.Write("Please Enter Mark of "+studentArray[i]+":");
            for(int j=0;j<marksArray.GetLength(1);j++){//GetLength(1) means to know array's columns 6            
              Console.Write("Please enter mark of subject "+(j+1)+":");
              marksArray[i,j]=int.Parse(Console.ReadLine());
            }
        }  
    //to print out student name and mark 
    Console.WriteLine("Exam Mark");
    Console.WriteLine("====================");
        for(int i=0;i<marksArray.GetLength(0);i++){
             Console.Write(studentArray[i]+" :"); // SU SU 
            for(int j=0;j<marksArray.GetLength(1);j++){
            Console.Write(marksArray[i,j]+" "); // 45 45 65 85 85 85     
            }          
            Console.WriteLine("\n====================");
        }
    }
}