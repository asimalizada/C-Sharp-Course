using System;

namespace Lesson15___Interface_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // public private internal protected

            Student student = new Student();
            student.Id = 9;

            Teacher teacher = new Teacher();
            //teacher.FirstName = "Ramiz";

            Person person = new Person();
            //person.Add(new Teacher(), new NewTeachable());

            ITeachable[] teachables = new ITeachable[2] { new Teachable(), new NewTeachable() };

            foreach (var teachable in teachables)
            {
                teachable.GiveScholarship();
            }
        }
    }
    interface IPerson  // abstract
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    interface IWork
    {
        void Work();
    }

    class Person : IPerson, IWork // Parent / Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Add(Person person, ITeachable teachable)
        { // defensive programming
            teachable.GiveScholarship();
            Console.WriteLine("Added!");
        }

        public void Work()
        {
            // some codes...
        }
    }

    interface ITeachable
    {
        void GiveScholarship();
    }

    class NewTeachable : ITeachable
    {
        public decimal Scholarship { get; set; }

        public void GiveScholarship()
        {
            Console.WriteLine("Scholarship was given by NewTeachable");
        }
    }

    class Teachable : ITeachable
    {
        public decimal Scholarship { get; set; }

        public void Add(Teachable teachable)
        {
            Console.WriteLine("Added!");
        }

        public void GiveScholarship()
        {
            Console.WriteLine("Scholarship was given by Teachable");
        }
    }

    class Graduates : Person
    {

    }

    class Student : Person // Child
    {
        public decimal Overall { get; set; }
    }

    class temp : Student
    {

    }
    class Teacher : Person // Child
    {
        public decimal Salary { get; set; }

        public void Temp(Teacher teacher)
        {
            Console.WriteLine(teacher.FirstName);
        }
    }

}

