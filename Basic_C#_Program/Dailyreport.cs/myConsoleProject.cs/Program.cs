using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            //string for name
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseType = Console.ReadLine();
            //int for # of page
            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int Page = Convert.ToInt32(pageNum);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string Help = Console.ReadLine();
            string helpQ = Convert.ToString(Help);
            //Feedback
            Console.WriteLine("were there any positive experiences you'd like to provide? Please be specific.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please give specific.");
            string feedback = Console.ReadLine();
            //convert hours 
            Console.WriteLine("How many hours did you study today?");
            string HoursStudied = Console.ReadLine();
            int studyingHours = Convert.ToInt32(HoursStudied);
            //final line
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();


        }
    }
}
