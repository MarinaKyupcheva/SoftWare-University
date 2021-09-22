using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName 
        {
            get => this.firstName;
            set
            {
               
             if (string.IsNullOrEmpty(firstName))
               {
                   throw new ArgumentNullException("The first name can not be null or negative");
               }

                this.firstName = value;
            }
        }

       

        public string LastName 
        {
            get => this.lastName;
            set
            {
               
                if (string.IsNullOrEmpty(lastName))
                {
                   throw new ArgumentNullException("The last name can not be null or negative");
                }
                this.lastName = value;
            }
        }
        public int Age 
        {
            get => this.age;
            set
            {
                if(value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age should be in the range [0 - 120].");
                }
                this.age = value;
            }
        }
       
       
    }
}
