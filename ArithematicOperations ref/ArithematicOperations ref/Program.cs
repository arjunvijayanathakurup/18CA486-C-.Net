using System;
using System.Xml.Schema;

namespace ArithematicOperations_ref
{
    class Number
    {
        int a;
        int b;
        int value;

        public Number()
        {
            a = 0;
            b = 0;
            value = 0;
        }
        public void add(ref int a, ref int b)
        {
            value = a + b;
            Console.WriteLine(a +  " + " + b + " = " + value);
        }
        public void sub(ref int a, ref int b)
        {
            value = a - b;
            Console.WriteLine(a + " - " + b + " = " + value);
        }
        public void mul(ref int a, ref int b)
        {
            value = a * b;
            Console.WriteLine(a + " x " + b + " = " + value);
        }
        public void div(ref int a, ref int b)
        {
            value = a / b;
            Console.WriteLine(a + " / " + b + " = " + value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            Number number = new Number();
            number.add(ref a, ref b);
            number.sub(ref a, ref b);
            number.mul(ref a, ref b);
            number.div(ref a, ref b);
            Console.ReadLine();
        }
    }
}
