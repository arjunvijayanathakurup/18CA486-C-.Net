using System;
using System.Collections;

namespace CollectionArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray bitArray = new BitArray(5);

            Console.WriteLine("Bit Array");
            Console.WriteLine("   Count:    {0}", bitArray.Count);
            Console.WriteLine("   Length:   {0}", bitArray.Length);
            Console.WriteLine("   Values:");
            foreach(Object obj in bitArray)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
}
