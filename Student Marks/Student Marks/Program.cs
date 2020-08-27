using System;

namespace Student_Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] group = new int[10];
            for(int i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            foreach(int i in a)
            {
                if(i >= 0 && i < 10)
                {
                    group[j] += 1;
                }else if(i >= 10 && i < 20)
                {
                    group[j + 1] += 1;
                }
                else if (i >= 20 && i < 30)
                {
                    group[j + 2] += 1;
                }
                else if (i >= 30 && i < 40)
                {
                    group[j + 3] += 1;
                }
                else if (i >= 40 && i < 50)
                {
                    group[j + 4] += 1;
                }
                else if (i >= 50 && i < 60)
                {
                    group[j + 5] += 1;
                }
                else if (i >= 60 && i < 70)
                {
                    group[j + 6] += 1;
                }
                else if (i >= 70 && i < 80)
                {
                    group[j + 7] += 1;
                }
                else if (i >= 80 && i < 90)
                {
                    group[j + 8] += 1;
                }
                else if (i >= 90 && i <= 100)
                {
                    group[j + 9] += 1;
                }
            }
            foreach(int i in group)
            {
                Console.WriteLine("Number of values in Group " + j + " is " + i + "\n");
                j++;
            }
            Console.ReadLine();
        }
    }
}
