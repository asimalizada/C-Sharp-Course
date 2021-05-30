using System;
using System.Linq;

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

    public static class StringExtensions
    {
        public static bool IsCorrectPhoneNumber(this string str)
        {
            //number +994 5 527 13 66
            string[] inceptions = { "50", "51", "55", "70", "77", "99" };
            if (str.Substring(0, 4) == "+994" && str.Length == 13 && inceptions.Contains(str.Substring(4, 2)))
            {
                return true;
            }

            return false;
        }
    }

    public static class IntegerExtensions
    {
        public static bool IsPrimaryNumber(this Int32 number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Person
    {
        public Person(int age, string firstName, string lastName)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string fatherName, string firstName, string lastName)
        {
            this.FatherName = fatherName;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(int age, string firstName, string lastName, string fatherName) : this(age, firstName, lastName)
        {
            this.FatherName = fatherName;
        }

        public Person()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }

        public int Age { get; set; }
    }
}