using System;
namespace Class_submission
{
    public class Math
    {
        public void Mathmethod(int input, int input2=2)
        {

            int answer = input / input2;
            Console.WriteLine(input + "/" + "2" + "=" + answer);
        }
        public static int Mathmethod(out int x, out int y)
        {

            x = 5;
            y = 20;
            return y / x;
        }
    }
}