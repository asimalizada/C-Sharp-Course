using System;

namespace Lesson11___Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            a = b;
            b = 30;
            Console.WriteLine(a);

            //GARBAGE COLLECTOR

            string[] characters = new string[3] { "A", "B", "C" };
            string[] numbers = { "1", "2", "3" };

            characters = numbers;
            numbers[0] = "4";

            //Console.WriteLine(characters[0]);

            //Value types--- int,double,long,bool 
            //Reference Types ---  
            string a = "a";
            string b = "b";
            a = b;

            int[] array = new int[] { 1, 2, 3 };
            DoSomething(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            int a = 20;
            DoSomething(a);
            Console.WriteLine(a);

            double faiz = 5;
            double kredit = 0;
            DoSomething(ref faiz);
            kredit = DoSomething2(out faiz);
            Console.WriteLine($"Musteri {faiz} - faizle {kredit} kredit goturdu");
        }
        static void DoSomething(int[] array)
        {
            array[0] = 999;
        }
        static void DoSomething(ref double a)
        {
            //a = 20;
        }
        static double DoSomething2(out double faiz)
        {
            if (true)
            {
                faiz = 30;
            }
            else
            {
                faiz = 40;
            }
            double kredit = 1000 * faiz / 100;
            return kredit;
        }
    }
}
