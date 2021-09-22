using System;
namespace Csharp_ProgrammingPractice
{
    public class FourPractices
    {
        // problem 1
        public int FindFactorial(int a)
        {
            int r = a;
            for (int i = a - 1; i > 0; i--)
            {
                r *= i;
            }

            return r;
        }


        // problem 2
        public bool PrimeOrNot(int a)
        {
            bool r = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    r = false;
                }
            }
            return r;
        }

        // problem 3
        public bool LeapYear(int y)
        {
            if (y % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // problem 4
        public int LCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                int mult = num1 * i;
                if (mult % num2 == 0)
                {
                    return mult;
                }
            }
            return num1 * num2;
        }

    }
}
