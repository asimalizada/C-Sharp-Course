using System;

namespace Lesson15___Interface_Inheritance
{
    class NewTeachable : ITeachable
    {
        public decimal Scholarship { get; set; }

        public void GiveScholarship()
        {
            Console.WriteLine("Scholarship was given by NewTeachable");
        }
    }
}