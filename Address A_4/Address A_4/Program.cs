using System;

namespace Address_A_4
{
    class Address
    {
        public void setAddress(params string[] str)
        {
            foreach(string st in str)
            {
                Console.WriteLine(st);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.setAddress("Kadampattu House", "Ponakam", "Mavelikkara P.O", "Aleppy", "");
            Console.ReadLine();
        }
    }
}
