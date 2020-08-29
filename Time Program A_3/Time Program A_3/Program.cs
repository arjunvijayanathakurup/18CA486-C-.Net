using System;

// Create a class ‘Class Time’ with the private members Year; Month; Date; Hour; Minute; Second;. Create a member function ‘public void DisplayTime( ) 
// to display the  time. The Time object needs to be created with the Current time (Use a constructor).   Test the class in main function. 

namespace Time_Program_A_3
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
            months = new string[12]{"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            month = months[now.Month - 1];
            date = now.Day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }
        public void DisplayTime()
        {
            Console.WriteLine("Date: " + date + "th" + month + "," + year);
            Console.WriteLine("Time: " + hour + ":" + minute + ":" + second);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.DisplayTime();
            Console.ReadLine();
        }
    }
}
