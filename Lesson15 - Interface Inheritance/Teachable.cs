using System;

namespace Lesson15___Interface_Inheritance
{
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
}