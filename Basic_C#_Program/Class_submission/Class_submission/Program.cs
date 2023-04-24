using System;

namespace Class_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Math Math2 = new Math();


            int userinput = Convert.ToInt32(Console.ReadLine());
            Math2.Mathmethod(userinput, 4);
        }
    }
}
