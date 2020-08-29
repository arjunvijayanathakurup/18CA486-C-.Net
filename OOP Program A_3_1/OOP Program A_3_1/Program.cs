using System;

namespace OOP_Program_A_3_1
{
    class Person
    {
        private String firstname, lastname;
        private int age;

        public Person()
        {
            firstname = null;
            lastname = null;
            age = 0;
        }
        public void addPerson(String firstname, String lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }
        public void viewPerson()
        {
            Console.WriteLine("First Name : " + firstname);
            Console.WriteLine("Last Name : " + lastname);
            Console.WriteLine("Age : " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a class Person with data members FirstName, LastName, Age. Write the proper constructor function to initialize it with proper values.
            // In constructor without parameter initialize the names with null and age with 0.   Add a method to receive the information from the user and 
            // another method to display the details of the person.Test the class in  Main function
            Person person = new Person();
            String firstname, lastname;
            int age;
            Console.Write("Enter First name : ");
            firstname = Console.ReadLine();
            Console.Write("Enter Last name : ");
            lastname = Console.ReadLine();
            Console.Write("Enter age : ");
            age = Convert.ToInt32(Console.ReadLine());
            person.addPerson(firstname, lastname, age);
            person.viewPerson();
            Console.ReadLine();
        }
    }
}
