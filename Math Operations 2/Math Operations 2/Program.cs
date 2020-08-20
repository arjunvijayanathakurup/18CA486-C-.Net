using System;

namespace Math_Operations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(" + a  + " + " +  b + ")." + c + " : " + ((a+b)*c));
            Console.WriteLine(a + "." + b + " + " + b + "." + c + " : " + ((a * b) + (b * c)));
            Console.ReadLine();
        }
    }
}
