using System;
 class Ladder {
	 static void Main() {
		int Step=3;//use for step
		int StepHeight=3;//use the same value of step
		int EachStepWidth=5;//use for width for each step		
		for(int i=EachStepWidth;i<=(StepHeight*EachStepWidth);i+=5) {// i loop  represent start of width 
		for(int j=1;j<=Step;j++) {//j loop represnt stpes
			for(int k=1;k<=i;k++) {
				if(k==1 || k==i || j==1 || j==Step) 
                {
				Console.Write("*");//print out * 
				}
                else 
                {
					Console.Write(" ");//print out space " "			
				}
			}//end of 1st inner loop
			Console.WriteLine();//print out new line			
		}//end of 2nd inner loop	
		}//end of outer loop
	}//end of main
	}//end of class
