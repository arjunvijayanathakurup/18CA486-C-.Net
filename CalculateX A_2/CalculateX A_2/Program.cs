using System;

namespace CalculateX_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int x = a / b - c;
            Console.WriteLine("Value of x is : " + x);
            Console.ReadLine();
        }
    }
}
