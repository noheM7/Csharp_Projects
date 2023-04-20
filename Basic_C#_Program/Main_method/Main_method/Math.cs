using System;
namespace Main_method
{
    public class Math
    {

        public static int multiply(int input, int input2)
        {
            int answer = (input * input2);
            return answer;

        }
        public static int Add(decimal input3, decimal input4)
        {
            int answer2 = Convert.ToInt32(input3 + input4);
            return answer2;

        }
        public static string String(string input5, string input6)
        {
            string answer3 = Convert.ToString(input5 + input6);
            return answer3;

        }



    }
}