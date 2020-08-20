using System;

namespace LargestAndSmallest_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int large = 0, small = 0;
            for(int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    small = arr[i];
                    large = arr[i];
                }
                else if(arr[i] < small)
                {
                    small = arr[i];
                }
                if(arr[i] > large)
                {
                    large = arr[i];
                }
            }
            Console.WriteLine("Largest Value is " + large);
            Console.WriteLine("Smallest Value is " + small);
            Console.ReadLine();
        }
    }
}
