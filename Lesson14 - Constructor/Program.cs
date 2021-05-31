using System;

namespace Lesson14___Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //string number = "+994565274599";
            //Console.WriteLine(number.IsCorrectPhoneNumber());
            //int number = 47;
            //Console.WriteLine(number.IsPrimaryNumber());

            Person ramiz = new Person(19, "Ramiz", "Veliyev", "Rafiq");
            Person asim = new Person(19, "Asim", "Elizade");
            Console.WriteLine(ramiz.FirstName + " " + ramiz.LastName + " " + ramiz.FatherName);
            Person person = new Person();
            person.FirstName = Console.ReadLine();
        }
    }
}