using System;

namespace Lesson22___Delegates
{
    static class Printer
    {
        public static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public static void PrintWelcome(string name)
        {
            Console.WriteLine($"Welcome, {name}!");
        }

        public static void PrintBye(string name)
        {
            Console.WriteLine($"Bye, {name}!");
        }
    }
}