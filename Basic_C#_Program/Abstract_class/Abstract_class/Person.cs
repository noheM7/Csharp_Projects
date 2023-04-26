using System;
namespace Abstract_class
{
    public abstract  class Person
    {
        public string firstName
        { get; set; }
        public string lastName
        { get; set; }

        public void SayName()
        {
            {
                string fullname = firstName + lastName;
                  Console.WriteLine("Name: " + fullname);
            }
        }
    }
    }
