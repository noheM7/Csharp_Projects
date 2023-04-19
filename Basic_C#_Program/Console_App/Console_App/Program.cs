using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App
{
    class Program
    {
        private static char npcID;

        static void Main(string[] args)
        {
            string[] Addition = { "1+2=", "3x1=", "6/2=" };
            Console.WriteLine("what is 1+2?");
            string input = Console.ReadLine();



            for (int x = 0; x < Addition.Length; x++)
            {
                Console.WriteLine(Addition[x] + " " + input);
            }

            Console.WriteLine("press enter for part 2");
            Console.ReadLine();


            //Part two of Console app 
            bool z = 2 > 1;
            while (z == 3 > 2)
            {
                Console.WriteLine("Infinite loop");
                //since false print once only
                z = 4 > 5;



                //Part 3 of Console App
                Console.WriteLine("Part 3");
                List<string> greaterThan = new List<string>() { "1", "2", "3", "4", "5" };
                        for (int G = 1; G < 3; G++)
                            Console.WriteLine(G);
                for (int E = 1; E <= 3; E++)
                    Console.WriteLine(E);




                    //Part 4 and 5  of Console App
                    Console.WriteLine("Enter a # 1-5 to see if it is in the list");
                string numberInput = Console.ReadLine();

                List<string> numberList = new List<string>() { "1", "3", "5", "2", "2" };


                //Outcome of user input for search
                if (!numberList.Contains(numberInput))

                {


                    Console.WriteLine("Try again.");

                }

                else
                {
                    for (int x = 0; x < numberList.Count; x++)
                    {
                        if (numberList[x] == numberInput)

                            Console.WriteLine(numberInput + " is in the list at " + x);
                    }
                }
            }


            //part 6 of Console App
            List<string> list = new List<string>() { "A", "B", "C", "C", "D" };

            //prints list
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            //finds duplicates and states it
            var duplicates = list.GroupBy(s => s.ToUpper())
                                     .Where(g => g.Count() > 1)
                                     .Select(g => g.Key);
            foreach (var dupe in duplicates)
                {

                    Console.WriteLine(dupe + " is a repeat ");
                
            
                   

            }
            

            
        }
    }
}