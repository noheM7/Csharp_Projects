using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime now = DateTime.Now;
            Console.WriteLine("input a number");
            int x = Convert.ToInt32(Console.ReadLine());

            DateTime usertime = now.AddHours(x);
            Console.WriteLine("it will be "+ usertime+ " in "+ x+ " hours");
           

        }
    }
}
