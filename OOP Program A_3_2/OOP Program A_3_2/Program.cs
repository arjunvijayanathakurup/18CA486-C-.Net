using System;

namespace OOP_Program_A_3_2
{
    class AnotherClass
    {
        public int ab;
        public int bc;

        public AnotherClass()
        {
            ab = 1000;
            bc = ab;
        }
        public void printVariables()
        {
            Console.WriteLine("Value of first variable is " + ab + " and value of second variable is " + bc);
        }
        public void printReferenceValue()
        {
            Console.WriteLine("Current value of first reference variable is " + ab + " and value of second variable is " + bc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Create a C# program with a class, (other than the class containing Main method) which has a public data member. 
            // Then declare and initialize one variable of value types and reference types (objects of the above class) in the Main method. 
            //Create a second variable of value type and reference type with the already existing first variables. (Hint: Assign the first to the second during declaration) 
            // then print the variables.  Then change the value of the first variables and print the second variables. 
            //What difference you see in the behavior of value types and reference types? Why?

            AnotherClass another = new AnotherClass();
            another.printVariables();
            Console.Write(" \n Enter a reference variable value : ");
            another.ab = Convert.ToInt32(Console.ReadLine());
            another.printReferenceValue();
            Console.ReadLine();
        }
    }
}
