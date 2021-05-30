using System;

namespace Lesson1___DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Daxil oldunuz!";//metn tipi
            string name = Console.ReadLine();

            int number1 = 35;//tam ededler
            int number2 = 23;
            int result = number1 / number2;
            double number1 = 14;//kesr ededler
            double number2 = 123131;
            long number3 = 123123123123123123;
            short number4 = 12;
            int number5 = 134123;
            number1 = number2;
            bool isRegistered = (5 <= 6);
            double money = 12123123.1231212123123123;
            decimal money2 = 12123123.1231212123123123M;
            char character = 'A';

            Console.WriteLine(money2);
        }
    }
}
