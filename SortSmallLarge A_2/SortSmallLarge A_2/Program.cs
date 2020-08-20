using System;
using System.Collections.Generic;

namespace SortSmallLarge_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 20, 40, 190, 45, 67, 97, 62, 37, 45, 64, 87, 154, 987, 7921, 564, 73, 94, 781, 98};
            int[] small = new int[10];
            int[] large = new int[10];
            Array.Sort(arr);
            int j = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(i < 10)
                {
                    small[i] = arr[i];
                }
                else
                {
                    large[j] = arr[i];
                    j++;
                }
            }
            Console.Write("\n Sorted Array is : ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n Small Sub array : ");
            foreach (int i in small)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n Large sub Array : ");
            foreach (int i in large)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
