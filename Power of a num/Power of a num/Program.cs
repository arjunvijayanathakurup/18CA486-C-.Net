using System;

namespace Power_of_a_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " ^ " + n + " : " + Math.Pow(a, n));
            Console.ReadLine();
        }
    }
}
