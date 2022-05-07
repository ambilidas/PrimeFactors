using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    internal class PrimeFactor
    {
        public void findPrimeFactor()
        {
            Console.WriteLine("Enter your number: ");
           int a=int.Parse(Console.ReadLine());

            for (int b = 2; a > 1; b++)
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is a prime factor {x} times!");
                }

        }
    }
}
