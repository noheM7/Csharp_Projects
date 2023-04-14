using System;

namespace Boolean_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //while statement
            int i = 0;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }
            {
                Console.WriteLine("Do while statement:");
                //do while statement
                int c = 7;
                do
                {
                    Console.WriteLine(c);
                    c++;
                }
                while (c < 11);
            }
            Console.WriteLine("Done!");
        }
    }
}