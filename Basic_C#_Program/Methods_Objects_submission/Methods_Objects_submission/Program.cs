using System;

namespace Methods_Objects_submission
{
    class Program
    {
        static void Main(string[] args)
        {

            Person employee = new Person();

                employee.FirstName = "Sample";
            employee.LastName = " Student";

            employee.SayName();
           
        }
    }
}
