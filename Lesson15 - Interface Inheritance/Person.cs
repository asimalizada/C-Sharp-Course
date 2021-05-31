using System;

namespace Lesson15___Interface_Inheritance
{
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
}