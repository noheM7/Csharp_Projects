using System;
using Operators_submission;

namespace OPerators_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee();

            person1.FirstName = "Connor";
            person1.LastName = "McGregor";
            person1.Id = "1";

            Employee person2 = new Employee();
            person2.FirstName = "Michael";
            person2.LastName = "Jordan";
            person2.Id = "12";

            Console.WriteLine("T/F does employee 1 have the same id as employee 2? "); 
            Console.WriteLine(person1.Id == person2.Id); 
            Console.ReadLine();
        }
    }
}
