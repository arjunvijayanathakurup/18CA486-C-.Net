using System;

namespace SumOfOddDigits_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] rem = new int[4];
            int n = 3, sum = 0;
            while (a != 0)
            {
                rem[n] = a % 10;
                a = a / 10;
                n--;
            }
            foreach(int i in rem)
            {
                if(i % 2 != 0 || i == 1)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
