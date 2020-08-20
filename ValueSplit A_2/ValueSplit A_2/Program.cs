using System;

namespace ValueSplit_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rem = new int[5];
            int n = 4;
            int a = Convert.ToInt32(Console.ReadLine());
            while(a != 0)
            {
                rem[n] = a % 10;
                a = a / 10;
                n--;
            }
            foreach(int i in rem)
            {
                Console.Write(i + "   ");
            }
            Console.ReadLine();
        }
    }
}
