using System;

namespace Student_OOP
{
    class Student
    {
        private string fullname;
        private string course;
        private string university;

        public Student()
        {
            Name = null;
            Course = null;
            University = null;
            Email = null;
            Phone = null;
        }

        public Student(string name, string course, string university, string email, string phone)
        {
            this.Name = name;
            this.Course = course;
            this.University = university;
            this.Email = email;
            this.Phone = phone;
        }
        public Student(string name, string course, string university)
        {
            this.Name = name;
            this.Course = course;
            this.University = university;
        }

        public void display()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Course : " + Course);
            Console.WriteLine("University : " + University);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Phone : " + Phone + "\n");
        }

        public string Name { get => fullname; set => fullname = value; }
        public string Course { get => course; set => course = value; }
        public string University { get => university; set => university = value; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Arjun", "MCA", "ASE", "arjunv@gmail.com", "9496701917");
            student.display();
            Student student1 = new Student("Arjun V", "BCA", "Amrita");
            student1.display();
            Console.ReadLine();
        }
    }
}
