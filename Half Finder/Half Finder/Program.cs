using System;

namespace Half_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            do
            {
                a = a / 2;
                Console.WriteLine(a);
            }
            while (a != 0);

            Console.ReadLine();
        }
    }
}
