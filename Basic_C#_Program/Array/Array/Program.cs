using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        //Array 1


        string[] stringArray = new string[] { "string 1", "string 2", "string 3", "string 4", "string 5", "string 6" };
        Console.WriteLine("Type a number from 0 to 5 to show where its at in the index.");
        int Array1 = Int32.Parse(Console.ReadLine());
        if (Array1 < stringArray.Length)
        {
            Console.WriteLine("The array stored at the number " + Array1 + " is " + stringArray[Array1]);
        }
        else
        {
            Console.WriteLine("Try again");

        }
         //Array 2
        int[] intArray = new int[] {6,5,4,3,2,1};
            Console.WriteLine("Choose from 0 to 5 to show where its at in index:");
            int Array2 = Int32.Parse(Console.ReadLine());
            if (Array2 < intArray.Length)
            {
                Console.WriteLine("The array # stored at index #" + Array2 + " is: " + intArray[Array2]);
            }
            else
            {
                Console.WriteLine("Try again");
            }

        //Array 3
        List<string> stringList = new List<string> { "Pizza", "Chicken Alfredo", "Sandwich", "Burger", "Mac n Cheese", "Pasta"};
        Console.WriteLine("Type a number from 0 to 5, you will see the food in this list:");
        int Array3 = Int32.Parse(Console.ReadLine());
        if (Array1 < intArray.Length )
        {
            Console.WriteLine("The food  stored at index " + Array3 + " is: " + stringList[Array3]);
        }
        else
        {
            Console.WriteLine("Try Again");
        }
        }
        }

