using System;

namespace Car_Insurance
{
    class Program
    {
        static void Main(string[] args)
        {

            //Age input
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            //DUI input
            Console.WriteLine("Have you ever had a DUI? (yes or no)");
            string DUI = Console.ReadLine();

            //speed ticket input
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();

            //Checker
            bool qualifiedage = Convert.ToInt32(age) > 15;
            bool qualifiedDUI = DUI == "no";
            bool qualifiedticket = Convert.ToInt32(ticket) <= 3;

            //outputs
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualifiedage && qualifiedDUI && qualifiedticket);
            Console.ReadLine();










        }
    }
}
