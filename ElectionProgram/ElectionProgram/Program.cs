using System;

namespace ElectionProgram
{
    class Election
    {
        private int candidate1;
        private int candidate2;
        private int candidate3;
        private int candidate4;
        private int candidate5;
        private int spoiltBallot;

        public Election()
        {
            candidate1 = 0;
            candidate2 = 0;
            candidate3 = 0;
            candidate4 = 0;
            candidate5 = 0;
            spoiltBallot = 0;
        }

        public void castVote(int votefor)
        {
            switch (votefor)
            {
                case 1:
                    candidate1++;
                    break;
                case 2:
                    candidate2++;
                    break;
                case 3:
                    candidate3++;
                    break;
                case 4:
                    candidate4++;
                    break;
                case 5:
                    candidate5++;
                    break;
                default:
                    spoiltBallot++;
                    break;
            }
        }

        public void displayResult()
        {
            Console.WriteLine("Votes status");
            Console.WriteLine("Candidate 1: " + candidate1);
            Console.WriteLine("Candidate 2: " + candidate2);
            Console.WriteLine("Candidate 3: " + candidate3);
            Console.WriteLine("Candidate 4: " + candidate4);
            Console.WriteLine("Candidate 5: " + candidate5);
            Console.WriteLine("Spoit Ballot: " + spoiltBallot);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* 5.An election is contested by five candidates. The candidates are numbered 1 to 5 and a voting is done by marking the candidate number in a ballot paper.
             Write a C# program to read the ballot and count the votes cast for each candidate using an array variable count. 
            In case, a number read is outside the range 1 to 5 the ballot should be considered as a ‘spoilt ballot’, and the program should also count the number of spoilt ballots. */
            int looper = 1;
            Election election = new Election();
            Console.WriteLine("Welcome to 2020 election.");
            while(looper != 0)
            {
                Console.WriteLine("Cast your vote. 1.  | 2. For Candidate 2 | 3. For Candidate 3 | 4. For Candidate 4 | 5. For Candidate 5");
                election.castVote(Convert.ToInt32(Console.ReadLine()));
                election.displayResult();
                Console.WriteLine("Do you want to continue? 0. Exit | 1. Continue");
                looper = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------");
            }

            Console.ReadLine();
        }
    }
}
