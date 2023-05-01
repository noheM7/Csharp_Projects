using System;

namespace Parsing_Enums
{
    class Program
    {
        public enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                Days userinput = (Days)Enum.Parse(typeof(Days), Console.ReadLine(), true);
                Console.WriteLine("The day you picked was " + userinput );
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
                 
            }
        }

    }
}