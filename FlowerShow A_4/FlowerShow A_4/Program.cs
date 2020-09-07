using System;
using System.Globalization;

namespace FlowerShow_A_4
{
    class Flower
    {
        private string flower_name;
        private int price_per_kg;
        private int stock_available;

        public Flower()
        {
            flower_name = "";
            price_per_kg = 0;
            stock_available = 0;
        }

        public string Flower_name { get => flower_name; set => flower_name = value; }
        public int Price_per_kg { get => price_per_kg; set => price_per_kg = value; }
        public int Stock_available { get => stock_available; set => stock_available = value; }

        public bool validate_flower()
        {
            if(flower_name.ToLower() is "orchid" || flower_name.ToLower() is "rose" || flower_name.ToLower() is "jasmin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validate_stock(int qty_required)
        {
            if(qty_required <= stock_available)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void sell_flower(int req_quantity)
        {
            if(validate_flower() && validate_stock(req_quantity))
            {
                stock_available = stock_available - req_quantity;
            }
        }
        public bool checked_level()
        {
            int flag = 0;
            switch (flower_name.ToLower())
            {
                case "orchid":
                    if (stock_available < 15)
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }
                    break;
                case "rose":
                    if (stock_available < 25)
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }
                    break;
                case "jasmin":
                    if (stock_available < 40)
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }
                    break;
            }
            if(flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
                    
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower();
            flower.Flower_name = "Jasmin";
            flower.Stock_available = 100;
            flower.Price_per_kg = 18;
            flower.sell_flower(50);
            Console.WriteLine("Current Stock for " + flower.Flower_name + " : " + flower.Stock_available);


            Flower flower1 = new Flower();
            flower1.Flower_name = "rose";
            flower1.Stock_available = 25;
            flower1.Price_per_kg = 30;
            flower1.sell_flower(25);
            Console.WriteLine("Current Stock for " + flower1.Flower_name + " : " + flower1.Stock_available);

            Flower flower2 = new Flower();
            flower2.Flower_name = "orchid";
            flower2.Stock_available = 20;
            flower2.Price_per_kg = 20;
            flower2.sell_flower(10);
            Console.WriteLine("Current Stock for " + flower2.Flower_name + " : " + flower2.Stock_available);

            Console.ReadLine();
        }
    }
}
