using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);
            c = a - b;
            Console.WriteLine(a + " - " + b + " = " + c);
            c = a * b;
            Console.WriteLine(a + " x " + b + " = " + c);
            c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);
            c = a % b;
            Console.WriteLine(a + " mod " + b + " = " + c);
            Console.ReadLine();
        }
    }
}
