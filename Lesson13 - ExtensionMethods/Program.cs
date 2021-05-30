using System;
using System.Linq;

namespace Lesson13___ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //private (metodlarda ve fieldlarda default olaraq private olur)
            //public 
            //internal
            Person person = new Person();
            person.Run();
            Console.WriteLine(Emeliyatlar.Sum(5, 6));
            Emeliyatlar emeliyatlar = new Emeliyatlar();
            Console.WriteLine(emeliyatlar.Difference(7, 3));
            emeliyatlar.Multy(4, 5);
            string a = "6";
            int b = 3;
            b.ToInt();
            double y = 3.5;
            y.ToInt();
            Console.WriteLine(a.ToInt());
            int c = a.ToInt();
            b.ToString();
            int x = ConsoleExtensions.ReadLineAsInteger();
            string name = "Ramiz";
            Console.WriteLine(name.Reverse());


            //string phoneNumber = "sdhgfjdshfjsd";
            //phoneNumber.IsCorrectPhoneNumberFormat();
        }
    }
    public class Emeliyatlar
    {
        public int Difference(int a, int b)
        {
            return a - b;
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            var charString = str.ToCharArray();
            Array.Reverse(charString);
            return new string(charString);
        }
    }
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
    public static class ObjectExtensions
    {
        public static int ToInt(this object @object)
        {
            return Convert.ToInt32(@object);
        }
        public static int Multy(this Emeliyatlar emeliyatlar, int a, int b)
        {
            return a * b;
        }
    }
    public static class ConsoleExtensions
    {
        public static int ReadLineAsInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
