using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _04Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] cmdArg = command.Split(" ");
                string firstName = cmdArg[0];
                string lastName = cmdArg[1];
                int age = int.Parse(cmdArg[2]);
                string city = cmdArg[3];

                Student student = new Student(firstName, lastName, age, city);
                students.Add(student);



                command = Console.ReadLine();
            }
            string nameOfCity = Console.ReadLine();
            students = students.Where(x => x.City == nameOfCity).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} { student.LastName} is { student.Age } years old.");
            }
           
        }
    }
    class Student
    {
        public Student (string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years.";
        }

    }
}
