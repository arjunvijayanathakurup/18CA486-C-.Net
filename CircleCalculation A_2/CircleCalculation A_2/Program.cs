using System;

namespace CircleCalculation_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area is " + pi * r * r);
            Console.WriteLine("Circumference is " + 2 * pi * r);
            Console.WriteLine("Diameter is " + 2 * r);
            Console.ReadLine();
        }
    }
}
