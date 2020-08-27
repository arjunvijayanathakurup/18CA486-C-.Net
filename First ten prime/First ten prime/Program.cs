using System;
using System.Globalization;

namespace First_ten_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int ct = 0, n = 0, i = 1, j = 1;
            while (n < 10)
            {
                j = 1;
                ct = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                        ct++;
                    j++;
                }
                if (ct == 2)
                {
                    Console.WriteLine(i);
                    n++;
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
