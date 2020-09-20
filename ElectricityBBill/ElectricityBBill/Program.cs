using System;

namespace ElectricityBBill
{
    class ElectricityBill
    {
        private string name;
        private int unitsComsumed;
        private double charges;

        public ElectricityBill()
        {
            name = null;
            unitsComsumed = 0;
            charges = 50;
        }

        public void calculateAmount(int units)
        {
            if(units <= 100)
            {
                charges += (units * 60);
            }
            else if(units > 100 && units <= 300)
            {
                charges += (units * 80);
            }
            else if(units > 300)
            {
                charges += (units * 90);
            }
            if(charges > 300)
            {
                charges += (charges * 15 / 100);
            }
        }

        public void printBill()
        {
            Console.WriteLine("Billing...");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Units consumed: " + this.unitsComsumed);
            Console.WriteLine("Amount to be paid: " + this.charges);
        }

        public void inputDetails(string name, int units)
        {
            this.name = name;
            this.unitsComsumed = units;
            calculateAmount(units);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int units = 0;
            Console.WriteLine("Enter customer details");
            ElectricityBill electricityBill = new ElectricityBill();    
            Console.Write("\nEnter the Customer name: ");
            name = Console.ReadLine();
            Console.Write("\nEnter the consumed units: ");
            units = Convert.ToInt32(Console.ReadLine());
            electricityBill.inputDetails(name, units);
            electricityBill.printBill();
            Console.ReadLine();

        }
    }
}
