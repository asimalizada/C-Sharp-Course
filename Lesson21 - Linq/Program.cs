using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson21___Linq
{
    class Program
    {
        static void Show<T>(List<T> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {   // LINQ -> Language Integrated Query

            Console.OutputEncoding = Encoding.UTF8;

            int[] array = { 1, 2, 3, 4, 5, 7, 8 };
            List<int> numbers = new List<int>(array);

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            //Show(evenNumbers);

            var primalNumbers = numbers.Where(IsPrimal).ToList();
            //Show(primalNumbers);

            List<Student> students = new List<Student>();

            students.Add(new Student
            {
                Id = 1,
                FirstName = "Ramiz",
                LastName = "Vəliyev",
                Age = 20
            });

            students.Add(new Student
            {
                Id = 2,
                FirstName = "Asim",
                LastName = "Əlizadə",
                Age = 19
            });

            students.Add(new Student
            {
                Id = 3,
                FirstName = "Əhməd",
                LastName = "Əhmədov",
                Age = 20
            });

            //var ramiz = students.FirstOrDefault(s => s.Id == 1);
            var ramiz = students.SingleOrDefault(s => s.Id == 1);

            //Console.WriteLine($"{ramiz.Id} {ramiz.FirstName} {ramiz.LastName}");

            numbers.Any();  // null->false

            var result = students.Where(s => s.Age == 20)
                .Select(s => s.FirstName + " " + s.LastName).ToList();

            //Show(result);

            string[] strings = { "Asim Alizade", "Ramiz Valiyev", "Ehmed Ehmedov" };
            List<string> names = new List<string>(strings);

            var resultNames = names.Select(n => n.Split()[0]).ToList();

            Show(resultNames);

            




        }

        static bool IsPrimal(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

    }

    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}