using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson19___List
{
    class Program
    { // ArrayList List Dictionary
        static void Main(string[] args)
        {
            // ArrayList

            ArrayList arrayList = new ArrayList(); // non-type-safety
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("K201");
            arrayList.Add(null);
            arrayList.Add(new Program());

            var temp = arrayList.OfType<object>().ToArray();

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
            //----------------------------------------------------------

            // List

            int[] nums1 = new int[5];
            List<int> numbers = new List<int>(nums1);

            numbers.Add(1);
            int[] nums = new int[5];
            numbers.AddRange(nums);
            numbers.Clear();
            numbers.Contains(0);
            numbers.Exists(n => n > 0);
            numbers.Find(n => n > 0);
            numbers.FindLast(n => n > 0);
            numbers.FindAll(n => n > 0);
            numbers.FindIndex(n => n > 0);
            numbers.FindLastIndex(n => n > 0);
            numbers.GetRange(0, 6);
            numbers.IndexOf(0);
            numbers.LastIndexOf(0);
            numbers.Insert(0, 5);
            numbers.InsertRange(0, nums);
            numbers.Remove(0);
            numbers.RemoveAll(n => n > 0); // Predicate / Lambda expression
            numbers.RemoveAt(0);
            numbers.RemoveRange(0, 7);
            numbers.Sort();
            numbers.Reverse();  // 1 2 3 4 -> 4 3 2 1
            numbers.TrueForAll(n => n > 0);


            Converter<int, double> converter = ConvertToDouble;
            List<double> newList = numbers.ConvertAll(converter);

            Converter<int, int> converterAboutAge = GetRealAge;
            var result = numbers.ConvertAll(converterAboutAge);

            // Dictionary

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            // Key-Value Pair
            dictionary.Add("kitab", "book");
            dictionary.Add("komputer", "computer");
            dictionary.Add("stəkan", "glass");

            string word = Console.ReadLine();
            if (dictionary.ContainsKey(word)) Console.WriteLine(dictionary[word]);

            var keys = dictionary.Keys.ToList();
            var values = dictionary.Values.ToList();

            Dictionary<int, string> categories = new Dictionary<int, string>();
            categories.Add(1, "Milk");
            categories.Add(2, "Meat");
            categories.Add(3, "Floor");

            int categoryId = int.Parse(Console.ReadLine());
            if (categories.ContainsKey(categoryId))
                Console.WriteLine(categories[categoryId]);

        }
        public static int GetRealAge(int age)
        {
            return age + 9;
        }

        public static double ConvertToDouble(int a)
        {
            return Convert.ToDouble(a);
        }
    }
}
