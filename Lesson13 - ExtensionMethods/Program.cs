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
}
