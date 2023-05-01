using System;

namespace Struct
{
    struct Number
    {
        public decimal Amount; 
    }


    class Program
    {
        static void Main(string[] args)
        {
            Number Num1; 
            Num1.Amount = 5000.0m; // assigned a decimal value to the object
            Console.WriteLine(Num1.Amount); 
       
        }
    }
}