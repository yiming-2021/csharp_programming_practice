
using System;

namespace Csharp_ProgrammingPractice
{

    class Program
    {

        // problem 1: Find the factorial of a number

        public int FindFactorial(int a)
        {
            int r = a;
            for (int i = a - 1; i > 0; i--)
            {
                r *= i;
            }

            return r;
        }


        // problem 2: if a number is prime or not
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

        // problem 3: if a year is leap or not
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

        // problem 4: LCM of two number
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



        static void Main(string[] args)
        {
            Program obj = new Program();


            // trial on each methods

            Console.WriteLine(obj.FindFactorial(3));
            Console.WriteLine(obj.PrimeOrNot(15));
            Console.WriteLine(obj.LeapYear(2021));
            Console.WriteLine(obj.LCM(3, 4));
        }
    }
}
