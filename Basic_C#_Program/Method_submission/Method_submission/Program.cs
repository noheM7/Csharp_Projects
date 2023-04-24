using System;

namespace Method_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input a second number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int answer = Math.multiply(input1, input2);
            Console.WriteLine(input1 + " * "+ input2+ " = "+answer);

        }
    }
}
