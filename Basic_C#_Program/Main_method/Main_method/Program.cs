using System;

namespace Main_method
{
    class Program
    {


         static void  Main(string[] args)
        {
          //method 1
            Console.WriteLine("Enter # to  add 10 to it:"); 
            int input = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(input+" + " +"10"+ " = " + Math.MyMethod(input));

            //method 2
            Console.WriteLine("input decimal to add 5 to it;");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            int answer2 = Math.MyMethod( input2);
            Console.WriteLine(input2 + " + " + 5 + " is equal to " + answer2 );


            //method 3
            Console.WriteLine("input string to add 2 to it;");
            string input3 = Console.ReadLine();
           
            Console.WriteLine(input3 + " + " + 2 + " is equal to " + Math.MyMethod(input3));

        }
    }
}
