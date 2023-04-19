using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in # to multiply by 32:");

            try
            {
                //Multiply
                int input = Convert.ToInt32(Console.ReadLine());


                int answer = Multiplication.multiply(input);

                Console.WriteLine(answer);

                //Addition
                Console.WriteLine("Put in a # and it will add 32:");
                int input2 = Convert.ToInt32(Console.ReadLine());


                int answer2 = Multiplication.Add(input);

                Console.WriteLine(answer2);



                //Subtraction
                Console.WriteLine("Put in a # and it will minus from 32:");
                int input3 = Convert.ToInt32(Console.ReadLine());


                int answer3 = Multiplication.Sub(input);

                Console.WriteLine(answer3);

            }
            catch(Exception)
            {
                Console.WriteLine( "Try again");
            }

            }
    }
}