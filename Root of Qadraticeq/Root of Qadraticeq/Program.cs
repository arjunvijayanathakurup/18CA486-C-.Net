using System;

namespace Root_of_Qadraticeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            double d, x1, x2;
            Console.WriteLine("Enter the values for a, b and c for the equation ax^2 + bx + c");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = (b * b) - (4 * a * c);

            if(d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("Value 1: " + x1);
                Console.WriteLine("Value 2: " + x2);
            }
            else if(d > 0)
            {
                x1 = Math.Abs(-b - Math.Sqrt(d)) / (2 * a);
                x2 = Math.Abs(-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Value 1: " + x1);
                Console.WriteLine("Value 2: " + x2);
            }
            else
            {
                Console.WriteLine("Cannot be calculated");

            }
            Console.ReadLine();
        }
    }
}
