using System;

namespace Average_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int avg = 0;
            for(int i = 0; i < 4; i++)
            {
                avg += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Average: " + avg / 4);
            Console.ReadLine();
        }
    }
}
