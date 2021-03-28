using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            PrimeNum(x);
        }

        private static void PrimeNum(int x)
        {
            int divider = 2;

            while (x % divider != 0)
            {
                divider++;
            }

            if (divider == x)
            {
                Console.WriteLine($"{x} is a prime number");
            }

            else
            {
                Console.WriteLine($"{x} is not a prime number");
            }
        }
    }
}
