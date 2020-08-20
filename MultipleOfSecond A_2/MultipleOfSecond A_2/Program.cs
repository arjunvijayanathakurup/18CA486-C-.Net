using System;

namespace MultipleOfSecond_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a % b == 0)
            {
                Console.WriteLine(a + " is a multiple of " + b);
            }
            else
            {
                Console.WriteLine(a + " is a not multiple of " + b);
            }
            Console.ReadLine();
        }
    }
}
