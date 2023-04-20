using System;

namespace Main_method
{
    class Program
    {
        private static int input3;
        private static decimal V;

        static void Main(string[] args)
        {
            try
            {           // Multiplication
                Console.WriteLine("Input a number to multiply:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input a second number to multiply the first number to:");
                int input2 = Convert.ToInt32(Console.ReadLine());
                int answer = Math.multiply(input, input2);
                Console.WriteLine(input + " * " + input2 + " = " + answer);


                //Addition with decimals
                Console.WriteLine("Input a number");
                decimal input3 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Input a second number");
                decimal input4 = decimal.Parse(Console.ReadLine());
                int answer2 = Math.Add(input3, input4);
                Console.WriteLine(input3 + " + " + input4 + " = " + answer2 + "Rounded");

            

                //string to integer
                Console.WriteLine("Input a string");
                string input5 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Input a second string to add to the first");
                string input6 = Convert.ToString(Console.ReadLine());
                string answer3 = Math.String(input5, input6);
                Console.WriteLine(answer3);

            }

            catch
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
