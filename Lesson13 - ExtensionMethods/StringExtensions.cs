using System;

namespace Lesson13___ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            var charString = str.ToCharArray();
            Array.Reverse(charString);
            return new string(charString);
        }
    }
}