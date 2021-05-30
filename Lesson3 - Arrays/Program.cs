using System;

namespace Lesson3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            int max = Int32.MinValue;
            if (a > max)
            {
                max = a;
            }
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine(max);

            int a = 5;
            int b = 7;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a-{a},b-{b}");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.WriteLine("6");
                    break;
                case 7:
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Please enter valid weekday!!");
                    break;
            }

            int n = Int32.Parse(Console.ReadLine());

            if (n <= 3)
            {
                Console.WriteLine("First");
            }
            else if (n <= 6)
            {
                Console.WriteLine("Second");
            }
            else if (n <= 9)
            {
                Console.WriteLine("Third");
            }
            else
            {
                Console.WriteLine("Fourth");
            }

            int[] numbers = new int[5];
            numbers[0] = 13;
            numbers[1] = 12;
            numbers[2] = 19;
            numbers[3] = 56;
            numbers[4] = 28;


            Console.WriteLine(numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]);

            string[] names = new string[] { "Ramiz", "Asim" };
            names[1] = "Eli";
            Console.WriteLine(names[1]);

            bool[] isLogins = { true, false, true };
            Console.WriteLine(isLogins[2]);


            char[] name = { 'R', 'A', 'M', 'I', 'Z' };
            Console.WriteLine(name[0]);
            name[0] = 'R';
            Console.WriteLine(new string(name));

            string name = "Ramiz";
            var charName = name.ToCharArray();
            charName[0] = 'Z';
            charName[2] = 'H';
            charName[4] = 'D';
            string number = 5.ToString();
            Console.WriteLine(new string(charName));

            int[] array = new int[3];
            int[,] numbers2 =
            { {1,2,3 },
              {4,5,6 },
              {9,5,3 }
            };
            numbers2[0, 0] = 5;
            numbers2[0, 1] = 4;

            numbers2[1, 0] = 7;
            numbers2[1, 1] = 7;

            numbers2[2, 0] = 9;
            numbers2[2, 1] = 16;

            //1 2 3
            //4 5 6
        }
    }
}
