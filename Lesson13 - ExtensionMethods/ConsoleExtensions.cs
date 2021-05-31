using System;

namespace Lesson13___ExtensionMethods
{
    public static class ConsoleExtensions
    {
        public static int ReadLineAsInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}