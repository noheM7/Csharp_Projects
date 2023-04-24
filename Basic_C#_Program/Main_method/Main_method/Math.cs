using System;
namespace Main_method
{
    public  class Math

    {
       //input integer

        public static int MyMethod(int input)
        {
            int answer = (input + 10);
            return answer;

        }
        //input decimal
        public static int MyMethod(decimal input2)
        {
            int answer2 = Convert.ToInt32(input2 + 5);
            return answer2;


        }
        //input string
        public static int MyMethod(string input3)
        {
            int answer3 = Convert.ToInt32(input3)+2;
            return answer3;

        }



    }
}