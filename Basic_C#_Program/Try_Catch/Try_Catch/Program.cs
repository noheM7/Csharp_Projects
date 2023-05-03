using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime currentDateTime = DateTime.Now;
                DateTime now = DateTime.Now;
                Console.WriteLine("input age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age<1)
                {
                    throw new Exception();
                }
                int ageconverter = age * -1;
              

                DateTime usertime = now.AddYears(ageconverter);
                int year = usertime.Year;
                Console.WriteLine( year+ " is the year you were born in. ");
            }
            catch (Exception )
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
