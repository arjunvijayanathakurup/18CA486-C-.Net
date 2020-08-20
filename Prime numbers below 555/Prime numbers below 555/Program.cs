using System;
using System.Threading;

namespace Prime_numbers_below_555
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            for(int i = 1; i <= 555; i++)
            {
                count = 0;
                for(int j = 2; j <= i / 2; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
