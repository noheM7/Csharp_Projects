using System;

namespace Math_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Compariosn Program");
            Console.WriteLine("Person 1 ");
            Console.WriteLine("Hourly Rate?");
            int HourlyWage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" hours worked per week:");
            int HoursWeekly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2 ");
            Console.WriteLine("Hourly Rate?");
            int HourlyWage2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" hours worked per week:");
            int HoursWeekly2 = Convert.ToInt32(Console.ReadLine());


            int AnnualSalary = HoursWeekly * HourlyWage * 52;
            int AnnualSalary2 = HoursWeekly2 * HourlyWage2 * 52;

            string Answer = "Annual Salary of Person 1: " + AnnualSalary;
            string Answer2 = "Annual Salary of Person 1: " + AnnualSalary2;

            Console.WriteLine(Answer);
            Console.WriteLine(Answer2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(AnnualSalary>AnnualSalary2);
        }
    }
}
