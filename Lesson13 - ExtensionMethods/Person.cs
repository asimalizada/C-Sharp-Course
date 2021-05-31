using System;

namespace Lesson13___ExtensionMethods
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public void Run()
        {
            Console.WriteLine(Emeliyatlar.Sum(5, 6));
        }
    }
}