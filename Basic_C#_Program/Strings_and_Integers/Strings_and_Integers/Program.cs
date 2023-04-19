using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> number = new List<int>{360, 50, 1500 };
                Console.WriteLine(String.Join(", ", number));
                Console.WriteLine("Choose number to divide these numbers by:");
                int divide = Convert.ToInt32(Console.ReadLine());
                for (int x = 0; x < number.Count; x++)
                {
                    int answer = number[x] / divide;
                    string j = Convert.ToString(x);
                    Console.WriteLine(number[x] + "/" + divide + " = " + answer);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("try again");
            }
           
        }
    }
}