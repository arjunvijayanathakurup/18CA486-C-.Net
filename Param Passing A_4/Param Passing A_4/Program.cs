using System;
using System.Diagnostics.CodeAnalysis;

namespace Param_Passing_A_4
{
    class Time
    {
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
        }
        public void SetTime(int hour, out int minute, ref int second)
        {
            DateTime now = DateTime.Now;
            this.hour = hour;
            minute = now.Minute;
            if(second > 60)
            {
                minute++;
                second = 0;
            }
            this.second = second;
            
        }
        public void GetTime()
        {
            Console.WriteLine("Time: " + hour + ":" + minute + ":" + second);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int hour = 06, minute, seconds = 10;
            Time time = new Time();
            time.SetTime(hour, out minute, ref seconds);
            time.GetTime();
            Console.ReadLine();
        }
    }
}
