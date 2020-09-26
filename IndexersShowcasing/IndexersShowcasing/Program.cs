using System;

namespace IndexersShowcasing
{
    class Program
    {
        private string[] sampleList = new string[size];
        static public int size = 10;

        public Program()
        {
            for(int i = 0; i < size; i++)
            {
                sampleList[i] = null;
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = sampleList[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    sampleList[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;

                while (index < size)
                {
                    if (sampleList[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program[0] = "Sample set 1";
            program[1] = "Sample set 2";
            program[2] = "Sample set 3";
            program[5] = "Sample set 5";

            for(int i = 0; i < Program.size; i++)
            {
                Console.WriteLine(program[i]);
            }

            for(int i = 0; i < Program.size; i++)
            {
                Console.WriteLine(program["Sample set " + i]);

            }

            Console.ReadLine();
        }
    }
}
