using System;

namespace TwoDimensionalArray_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int diag_sum = 0;
            int[,] arr = new int[5, 5]{ 
                {13, 14, 16, 95, 84 }, 
                {65, 34, 48, 57, 24 }, 
                {36, 734, 04, 94, 94 }, 
                {72, 87, 98, 67, 32 }, 
                {75, 85, 24, 4, 6 } 
            };

            for(int i = 0; i < 5; i++)
            {
                int sum_row = 0;
                for(int j = 0; j < 5; j++)
                {
                    sum_row += arr[i, j];
                    if(i == j)
                    {
                        diag_sum += arr[i, j];
                    }
                }
                Console.WriteLine("Sum of row " + i + " " + sum_row);
            }
            Console.WriteLine("Sum of diagonal elements : " + diag_sum);
            Console.ReadLine();
        }
    }
}
