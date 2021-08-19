using System;
using System.Collections.Generic;

namespace Assignment6
{
    internal class Program
    {
        public static void Main()
        {
            //Create a collection to store employees
            List<Employee> empList = new List<Employee>
            { new Employee() { Name = "Anurag", Gender = 0 },
                new Employee() { Name = "Pranaya", Gender = 1 },
                new Employee() { Name = "Priyanka", Gender = 2 },
                new Employee() { Name = "Sambit", Gender = 3 }
            };

            //Loop through each employees and print the Name and Gender
            foreach (var emp in empList)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", emp.Name, GetGender(emp.Gender));
            }

            Console.ReadLine();
        }

        //This method is used to return the Gender 
        public static string GetGender(int gender)
        {
            // The switch here is less readable because of these integral numbers
            return gender switch
            {
                0 => "Unknown",
                1 => "Male",
                2 => "Female",
                _ => "Invalid Data for Gender",
            };
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
    public enum Gender
    {
        Unknown,
        Male,
        Female,
    }


    //Program using Constractors in C# 
    // Default Constractor
    internal class Multiplication
    {
        private int a, b;
        public Multiplication()
        {
            a = 10;
            b = 5;
        }

        // Main Method
        public static void Main1()
        {

            // an object is created, 
            // constructor is called
            Multiplication obj = new Multiplication();

            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);

            Console.WriteLine("The result of multiplication is: " + (obj.a * obj.b));
        }

    }

    // C# program Using Parameterized Constructor
    internal class User
    {
        public string name, location;
        private User user;

        public User(User user)
        {
            this.user = user;
        }

        public User(string a, string b)
        {
            name = a;
            location = b;
        }
    }

    internal class Program1
    {
        public static void Main2()
        {
            // The constructor will be called automatically once the instance of the class created
            User user = new User("Suresh Dasari", "Hyderabad");
            Console.WriteLine(user.name);
            Console.WriteLine(user.location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }

    //Copy Constructors in C#
    internal class User2
    {
        public string name, location;
        // Parameterized Constructor
        public User2(string a, string b)
        {
            name = a;
            location = b;
        }
        // Copy Constructor
        public User2(User2 user2)
        {
            name = user2.name;
            location = user2.location;
        }
    }

    internal class Program3
    {
        private static void Main3(string[] args)
        {
            // User object with Parameterized constructor
            User user = new User("Suresh Dasari", "Hyderabad");
            // Another User object (user1) by copying user details
            User user1 = new User(user)
            {
                name = "Rohini Alavala",
                location = "Guntur"
            };
            Console.WriteLine(user.name + ", " + user.location);
            Console.WriteLine(user1.name + ", " + user1.location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }

    // C# program using value type
    internal class Program4
    {
        private static void Square(int a, int b)
        {
            a *= a;
            b *= b;
            Console.WriteLine(a + " " + b);
        }

        private static void Main4()
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num1 + " " + num2);
            Square(num1, num2);
            Console.WriteLine(num1 + " " + num2);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }

    // C# program usong reference type
    internal class Person
    {
        public int age;
    }

    internal class Program5
    {
        public static void Square(Person a, Person b)
        {
            a.age *= a.age;
            b.age *= b.age;
            Console.WriteLine(a.age + " " + b.age);
        }
        public static void Main4(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Person p1 = new Person();
            Person p2 = new Person();
            p1.age = 5;
            p2.age = 10;
            Console.WriteLine(p1.age + " " + p2.age);
            Square(p1, p2);
            Console.WriteLine(p1.age + " " + p2.age);
            Console.WriteLine("Press Any Key to Exit..");
            Console.ReadLine();
        }
    }




}
