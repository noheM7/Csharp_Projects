using System;

namespace Parsing_Enums
{
    class Program
    {

        //Enum for days of week
        public enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,
        }
        static void Main(string[] args)
        {
            try
            {
                //user inputs day of the week
                Console.WriteLine("Enter the current day of the week.");
                //Parse through enum to find days
                Days userinput = (Days)Enum.Parse(typeof(Days), Console.ReadLine(), true);


                //tells user what was input
                Console.WriteLine("The day you picked was " + userinput );
                Console.ReadLine();
            }
            catch (Exception)
            {
                //catchs its not in emun and try again
                Console.WriteLine("Please enter an actual day of the week. Try Again");
                 
            }
        }

    }
}