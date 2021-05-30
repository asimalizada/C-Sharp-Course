using System;

namespace Lesson2___IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input);
            //ASCII 
            int number1 = Int32.Parse("4");//BU ancaq stringi cevirir
            int charInt = 'A';
            long charLong = charInt;
            int sentence = Convert.ToInt32("4");
            int number = Convert.ToInt32(charLong);

            var a = "123";
            var b = 123;

            dynamic a = 12;
            a = true;

            bool isSubscribe = false;

            if (isSubscribe)
            {
                Console.WriteLine("Abune olundu");
            }
            else
            {
                Console.WriteLine("abune ol");
            }

            int number = Int32.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Musbetdir");
            }
            else if (number == 0)
            {
                Console.WriteLine("Sifir");
            }
            else
            {
                Console.WriteLine("Menfidir");
            }
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(-number);
            }

            Console.WriteLine(number >= 0 ? number : -number);

            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);//(1,2,3)
            int a = numbers[0];
            int b = numbers[1];
            int c = numbers[2];
            if (numbers[0] == numbers[1])
            {
                if (numbers[1] == numbers[2])
                    Console.WriteLine(1);
                else
                    Console.WriteLine(2);
            }
            else if (numbers[1] == numbers[2])
                Console.WriteLine(2);
            else if (numbers[0] == numbers[2])
                Console.WriteLine(2);
            else
                Console.WriteLine(3);
            if (a == b && b == c)
                Console.WriteLine(1);
            else if (a == b || a == c || b == c)
                Console.WriteLine(2);
            else
                Console.WriteLine(3);
        }
    }
}
