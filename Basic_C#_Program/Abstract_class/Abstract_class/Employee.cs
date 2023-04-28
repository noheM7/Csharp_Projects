using System;
namespace Abstract_class
{
    public class Employee : Person, IQuittable
    {
        public void Quit(Employee employee)
        {
            Console.WriteLine("Employee Quit!!");


        }

     
    }
}
