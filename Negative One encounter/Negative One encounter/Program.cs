using System;

namespace Negative_One_encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, count_zero = 0, count_pos = 0, count_neg = 0;
            while(a!= -1)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if(a == 0)
                {
                    count_zero += 1;
                }else if(a > 1){
                    count_pos += 1;
                }
                else if (a < 0)
                {
                    count_neg += 1;
                }
            }
            Console.WriteLine("Count of negative numbers are:" + count_neg + "\n Count of Positive numbers are: " + count_pos + "\n Count of Zeros are: " + count_zero);
            Console.ReadLine();
        }
    }
}
