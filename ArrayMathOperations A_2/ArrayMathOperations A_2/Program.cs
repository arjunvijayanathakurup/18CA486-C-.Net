using System;

namespace ArrayMathOperations_A_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int sum = 0, smallest = 0, largest = 0, product = 1;
            Console.WriteLine("Input three different integers: ");
            for(int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
                product *= arr[i];
                if(i == 0)
                {
                    smallest = arr[i];
                    largest = arr[i];
                }
                else if(arr[i] < smallest)
                {
                    smallest = arr[i];
                }
                if(arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine("Sum is : " + sum);
            Console.WriteLine("Average is :" + sum / arr.Length);
            Console.WriteLine("Product is : " + product);
            Console.WriteLine("Largest Value is: " + largest);
            Console.WriteLine("Smallest Value is: " + smallest);
            Console.ReadLine();
        }
    }
}
