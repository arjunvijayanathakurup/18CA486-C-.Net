using System;

namespace Calculations_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of " + a + " & " + b + " are " + (a + b));
            Console.WriteLine("Product of " + a + " & " + b + " are " + (a * b));
            Console.WriteLine("Difference of " + a + " & " + b + " are " + (a - b));
            Console.WriteLine("Quotient of " + a + " & " + b + " are " + (a / b));
            Console.ReadLine();
        }
    }
}
