using System;

namespace Class_submission
{
    class Program
    {
        public static void Main(string[] args)
        {



            Math Math2 = new Math();

            Console.WriteLine("Enter number to divide by two:");
            int userinput = Convert.ToInt32(Console.ReadLine());
            Math2.Mathmethod(userinput,2);


            //static class
            Console.WriteLine("this is the static output\n"+"20/5="+Math.Mathmethod(out int x, out int y));

        }

    }
}
