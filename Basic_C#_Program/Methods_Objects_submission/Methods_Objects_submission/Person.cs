using System;
namespace Methods_Objects_submission
{
    public class Person
    {



        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }

        public void SayName()
        {
            string fullname = FirstName + LastName;
            Console.WriteLine("Name: " + fullname);
        }
    }

}