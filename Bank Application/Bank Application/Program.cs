using System;
using System.Runtime.CompilerServices;

namespace Bank_Application
{
    class Bank
    {
        private string name;
        readonly private int accno;
        private string type;
        private int balance;
        private static int rate;

        public string Name { get => name; set => name = value; }

        public int Accno => accno;

        public string Type { get => type; set => type = value; }

        public int Balance => balance;

        public Bank()
        {
            Name = null;
            accno = 0;
            Type = null;
            balance = 0;
            rate = 5;
        }

        public Bank(string name, int accno, string type, int balance)
        {
            this.Name = name;
            this.accno = accno;
            this.Type = type;
            this.balance = balance;
            
        }

        public Bank(Bank bank)
        {
            name = bank.name;
            accno = bank.accno;
            type = bank.type;
            balance = bank.balance;
        }

        public void deposit(int accno, int amount)
        {
            if(this.accno == accno)
            {
                this.balance += amount;
            }
        }
        public void withdraw(int accno, int amt)
        {
            if(this.accno == accno && amt > 1000)
            {
                if(amt < balance)
                {
                    this.balance -= amt;
                    Console.WriteLine("Amount Withdrawn : " + amt);
                    Console.WriteLine("Balance : " + this.balance);
                    Console.WriteLine("-----------------------------------------");
                }
                else
                {
                    Console.WriteLine("Amount exceeds balance");
                }
            }
            else
            {
                Console.WriteLine("Can't withdraw");
            }
        }

        public void display()
        {
            Console.WriteLine("-----Bank Details-----");
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Account No. : " + this.accno);
            Console.WriteLine("Type : " + this.type);
            Console.WriteLine("Balance : " + this.Balance);
            displayInterest();
            Console.WriteLine("-----------------------------------------");

        }
        public static void displayInterest()
        {
            Console.WriteLine("Interest rate is " + rate + "%");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();
            bank = new Bank("Arjun", 125456563, "Savings", 20000);
            bank.display();
            bank.withdraw(125456563, 10000);
            bank.display();
            bank.deposit(125456563, 10000);
            bank.display();

            Bank b2 = new Bank(bank);
            b2.display();
            Console.ReadLine();
        }
    }
}
