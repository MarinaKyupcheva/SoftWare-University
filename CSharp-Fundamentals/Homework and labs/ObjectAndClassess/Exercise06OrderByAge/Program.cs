using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise06OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
           

            string command = Console.ReadLine();

            
            while (command != "End")
            {
                string[] cmdArg = command.Split(" ");
                string name = cmdArg[0];
                string id = cmdArg[1];
                int age = int.Parse(cmdArg[2]);



                Student student = new Student(name, id, age);
                students.Add(student);

                command = Console.ReadLine();



            }

            students = students.OrderBy(x => x.Age).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }



        }
    }
    class Student
    {
        public Student(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get;  set; }
        public string ID { get; set; }
        public int Age { get; set; }

       public override string ToString()
      {
    
           return $"{Name} {ID} {Age}";
       }
    }
}
