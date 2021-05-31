using System;

namespace Lesson15___Interface_Inheritance
{
    class Teacher : Person // Child
    {
        public decimal Salary { get; set; }

        public void Temp(Teacher teacher)
        {
            Console.WriteLine(teacher.FirstName);
        }
    }
}