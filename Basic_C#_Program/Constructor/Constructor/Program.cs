using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 8;
            var z = 9;

            chain chain2 = new chain();
            Console.WriteLine(x+ " is the constant.\n"+ z + " is the variable.\n" + chain2.Name + chain2.Id + " is the constructors together.");
        }
    }
}
