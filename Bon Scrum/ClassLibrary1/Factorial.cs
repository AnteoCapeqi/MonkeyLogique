using System;

namespace ClassLibrary1
{
    public class Factorial
    {
        public static int Calculate(int a)
        {
            int result = 1;
            if (a == 0)
            {
                result = 1;
            }
            else
            {
                while (a > 0)
                {
                    result = result * a;
                    a--;
                }
            }
            return result;
        }
    }
}