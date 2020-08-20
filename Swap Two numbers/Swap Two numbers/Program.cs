using System;

namespace Swap_Two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("First Number: " + a);
            Console.WriteLine("Second Number: " + b);
            Console.ReadLine();
        }
    }
}
