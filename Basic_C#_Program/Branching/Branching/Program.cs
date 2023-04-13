using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("\nEnter Package Weight");

            int Weight = Convert.ToInt32(Console.ReadLine());
            if (Weight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                //input of WLH
                Console.WriteLine("\nEnter the package width.");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the package height.");
                int Height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the package length.");
                int Length = Convert.ToInt32(Console.ReadLine());

                //Checker for size
                if ((width + Length + Height) > 50)
                {
                    Console.WriteLine("Your package is too big to be shipped via Package Express.");
                }
                else
                {
                     int total = (width * Height * Length) * Weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $ " + total);
                    Console.WriteLine("Thank you!");
                   
                }
            }
        }
    }
}
