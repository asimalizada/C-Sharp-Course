using System;

namespace Lesson7___String
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetings = "WWWWWWWWelcome, WelcomeWWWWWW";
            string groupName = "K201!";

            string clone = (string)greetings.Clone();
            string clone1 = greetings;

            int result1 = greetings.CompareTo(groupName); // true -> 0  false -> 1

            bool result2 = greetings.Contains("asim"); // key sensitive+  key-insensitive-

            bool start = greetings.StartsWith("K");
            bool end = greetings.EndsWith("K");

            int firstIndex = greetings.IndexOf("me"); // 5
            int lastIndex = greetings.LastIndexOf("me"); // 14

            string insert = greetings.Insert(8, "K201");

            int length = groupName.Length; // 4

            string remove1 = greetings.Remove(7);
            string remove2 = greetings.Remove(7, 2);

            string substring1 = greetings.Substring(7);
            string substring2 = greetings.Substring(7, 2);

            string replace = greetings.Replace(" ", "");

            string upper = greetings.ToUpper();
            string lower = greetings.ToLower();


            string trim = greetings.Trim('W');
            string trimEnd = greetings.TrimEnd();
            string trimStart = greetings.TrimStart();

            char[] arr = greetings.ToCharArray();
            string[] array = greetings.Split(' ', '_');

            //// Welcome|Welcome_K201__

            //// Welcome
            //// Welcome
            //// K201
            //// ""

            ////regex

            char[] ch = { 'a', 'b', 'c' };
            var temp = greetings.IndexOfAny(ch);

            string sentence = Console.ReadLine();

            var words = sentence.Split();
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith('a') | words[i].StartsWith('A')) count++;
            }
        }
    }
}
