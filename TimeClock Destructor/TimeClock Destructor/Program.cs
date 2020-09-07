using System;
using System.Threading;

namespace TimeClock_Destructor
{
    // Create another static member to hold the count of ‘ClassTime’ objects currently active.Then
    // display the value using a member function.Does the member function need to be static or non static? Why?
    class Time
    {
        static int count;
        private int year;
        private string[] months;
        private string month;
        private int date;
        private int hour;
        private int minute, second;
        public Time()
        {
            DateTime now = DateTime.Now;
            year = now.Year;
            months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            month = months[now.Month - 1];
            date = now.Day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
            count++;
        }
        
        public void countView()
        {
            Console.WriteLine("Count is " + count);
        }
        public void DisplayTime()
        {
            Console.WriteLine("Date: " + date + "th" + month + "," + year);
            Console.WriteLine("Time: " + hour + ":" + minute + ":" + second);
        }
        ~Time()
        {
            Console.WriteLine("Constructor Destroyed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.DisplayTime();
            Time time1 = new Time();
            time1.DisplayTime();
            Time time2 = new Time();
            time2.DisplayTime();
            time2.countView();
            GC.Collect();
            Console.ReadLine();
        }
        
    }
}


