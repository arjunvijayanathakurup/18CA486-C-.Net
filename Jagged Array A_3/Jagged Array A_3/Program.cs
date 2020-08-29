using System;

namespace Jagged_Array_A_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Jagged array to hold question numbers answered by the students of your class in a quiz competition.The program should have options to see the status of all the students
            int[][] questions = new int[3][];
            questions[0] = new int[5] { 0, 1, 1, 1, 0 };
            questions[1] = new int[5] { 1, 0, 1, 1, 0 };
            questions[2] = new int[5] { 1, 1, 1, 0, 0 };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine("Student having roll number " + (i + 1) + " answered: ");
                for(int j = 0; j < questions[i].Length; j++)
                {
                    if(questions[i][j] == 1)
                    {
                        Console.Write("Question " + j + " ");
                    }
                }
                Console.Write("Out of 5 Questions");
                Console.WriteLine();
                Console.WriteLine();
            }
         Console.ReadLine();
        }
    }
}
