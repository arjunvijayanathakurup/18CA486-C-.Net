using System;
using System.Diagnostics.CodeAnalysis;

namespace CloseToAverage_A_2
{
    class Program
    {
        static int pos;
        static int getValue(int[] arr, int avg)
        {
            if (avg <= arr[0])
            {
                pos = 0;
                return arr[0];
            }
            if (avg >= arr[arr.Length - 1])
            {
                pos = arr.Length - 1;
                return arr[arr.Length - 1];
            }
            int i = 0, j = arr.Length, mid = 0;
            while (i < j)
            {
                mid = (i + j) / 2;

                if (arr[mid] == avg)
                {
                    pos = mid;
                    return arr[mid];
                }
                if (avg < arr[mid])
                {
                    if (mid > 0 && avg > arr[mid - 1])
                    {
                        if (avg - arr[mid - 1] >= arr[mid] - avg)
                        {
                            pos = mid - 1;
                            return arr[mid];
                        }
                        else
                        {
                            pos = mid ;
                            return arr[mid - 1];
                        }
                        
                    }
                    j = mid;
                }
                else
                {
                    if (mid < arr.Length - 1 && avg < arr[mid + 1])
                    {
                       

                        if (avg - arr[mid] >= arr[mid + 1] - avg)
                        {
                            pos = mid + 1;
                            return arr[mid + 1];
                        }
                        else
                        {
                            pos = mid;
                            return arr[mid];
                        }
                        
                    }
                    i = mid + 1;
                }
            }
            pos = mid;
            return arr[mid];
        }
        static void Main(string[] args)
        {
            int sum = 0, avg = 0;
            int[] arr = { 10, 230, 1, 100, 45, 756, 363, 456, 454 };
            Console.Write("Values are ");
            foreach(int k in arr)
            {
                Console.Write(k + " ");
                sum += k; 
            }
            avg = sum / arr.Length;
            Console.WriteLine("\n Average is " + avg);
            Console.WriteLine(getValue(arr, avg) + " at position " + pos);
            Console.ReadLine();
        }

    }
}
