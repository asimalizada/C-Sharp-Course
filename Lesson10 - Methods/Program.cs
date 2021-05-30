using System;
using System.Linq;

namespace Lesson10___Methods
{
    class Program
    {
        static void PrintHello() // nr np  Access Modifier
        {
            Console.WriteLine("Hello, K201!");
        }

        static void PrintHelloByName(string name) // nr yp
        {
            Console.WriteLine($"Hello, {name}");
        }

        static int Input() // yr np
        {
            return int.Parse(Console.ReadLine());
        }

        static double Sum(double a, double b) // yr yp
        {
            return a + b;
        }

        SOLID - S -> Single Responsibility
        static void Print()
        {
            bool isDivide;
            for (int i = 1; i <= 100; i++)
            {
                isDivide = false;
                if (isDivideToThree(i))
                {
                    isDivide = true;
                    Console.Write("Fizz");
                }

                if (isDivideToFive(i))
                {
                    isDivide = true;
                    Console.Write("Buzz");
                }

                if (isDivide)
                {
                    Console.Write(i);
                }

                Console.Write(" ");
            }
        }

        static bool isDivideToThree(int number)
        {
            return number % 3 == 0;
        }

        static bool isDivideToFive(int number)
        {
            return number % 5 == 0;
        }

        static void PrintHello(string name = "Guest")
        {
            Console.WriteLine($"Hello, {name}");
        }
        static void PrintHello1(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        static void PrintSum(int a, int b = 10, int c = 10)
        {
            Console.WriteLine(a + b);
        }

        static int Sum(int[] a) // n sayda ededin cemi
        {
            return a.Sum();
        }

        static int Sum(int a, int b)  // method overloading
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        static int Sum(params int[] a)
        {
            return a.Sum();  // LINQ
        }

        static void Main(string[] args)  // Do not repeat yourself
        {
            // return-parameter  0 0, 0 1, 1 0, 1 1

            PrintHello();
            PrintHelloByName("Ilkin");
            int input = Input();
            double sum = Sum(5, 6);

            // 3 - Fizz 5 - Buzz 3 & 5 - FizzBuzz  usable

            Print();

            PrintHello();
            PrintHello("Emir");

            PrintHello1(Console.ReadLine());
            PrintSum(c: 5, a: 7);

            Sum(2, 3, 6, 8);

            Sum(1, 4, 5, 3, 2, 5, 5, 4, 6, 5, 5, 3, 4, 2, 3, 43, 2, 6787, 3, 9);

        }
    }
}
