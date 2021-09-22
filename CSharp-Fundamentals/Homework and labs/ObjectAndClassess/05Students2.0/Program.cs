using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] cmdArg = command.Split(" ");
                string firstName = cmdArg[0];
                string lastName = cmdArg[1];
                int age = int.Parse(cmdArg[2]);
                string city = cmdArg[3];


                Student student =
                       students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
                bool firstNameExist = students.Exists(s => s.FirstName.Contains(firstName));
                bool lastNameExist = students.Exists(s => s.LastName.Contains(lastName));
                if (student != null)
                {
                    var firstRepitableIndex = students.IndexOf(student);
                    students.RemoveAt(firstRepitableIndex);
                    
                }
                else
                {
                    student = new Student(firstName, lastName, age, city);
                  
                    students.Add(student);
                }

                command = Console.ReadLine();
            }

            string nameOfCity = Console.ReadLine();
            List<Student> FilteredStudent = students.Where(x => x.City == nameOfCity).ToList();

            foreach (Student student in FilteredStudent)
                {
                    Console.WriteLine($"{student.FirstName} { student.LastName} is { student.Age } years old.");
                }

            
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string city)
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
