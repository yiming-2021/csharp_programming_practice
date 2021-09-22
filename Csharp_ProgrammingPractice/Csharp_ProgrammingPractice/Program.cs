
using System;

namespace Csharp_ProgrammingPractice
{

    class Program
    {

        


        static void Main(string[] args)
        {
            FourPractices obj = new FourPractices();


            // trials on each methods

            Console.WriteLine(obj.FindFactorial(3));
            Console.WriteLine(obj.PrimeOrNot(15));
            Console.WriteLine(obj.LeapYear(2021));
            Console.WriteLine(obj.LCM(3, 4));
        }
    }
}
