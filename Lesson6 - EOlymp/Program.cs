using System;
using System.Linq;

namespace Lesson6___EOlymp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. usul  Ternary operation
            string n = Console.ReadLine();
            Console.WriteLine(n[0] == '-' ? n.Length - 1 : n.Length);

            //2.usul
            double n = double.Parse(Console.ReadLine());
            int length = (int)Math.Log10(n) + 1;

            //3.usul
            int n = Convert.ToInt32(Console.ReadLine());
            int length = 0;

            while (n != 0)
            {
                length++;
                n /= 10;
            }

            int n = int.Parse(Console.ReadLine());
            int count = 0, number;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number / 2 % 2 != 1) continue;
                count++;
            }

            int n = int.Parse(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(tokens[i]);
            }

            int min = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min) min = number;
            }

            Console.WriteLine(min);
            numbers.Min();

            int n = int.Parse(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split();
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(tokens[i]);
                //if (numbers[i] <= 2.5)
                //{
                //    Console.WriteLine("{0} {1:F2}", i+1, numbers[i]);
                //    break;
                //}
            }

            double result = numbers.FirstOrDefault(num => num <= 2.5);
            double result1 = Array.Find(numbers, num => num <= 2.5);

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(tokens[j]);
                    if (matrix[i, j] > 0) sum += matrix[i, j];
                }
            }

            Console.WriteLine(sum);

            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]); // 0
            int b = int.Parse(tokens[1]); // 10


            if (a % 2 == 0)
            {
                for (int i = a + 1; i <= b; i += 2)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    Console.Write(i + " ");
                }
            }

            string[] tokens = Console.ReadLine().Split();
            int n = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            int n = int.Parse(Console.ReadLine()); // 25  [11;19]
            int count = 0;
            bool isSquare = false;

            if (n % Math.Sqrt(n) == 0)
            {
                isSquare = true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++) // (n/2;n)
            {
                if (n % i == 0) count++;
            }

            if (isSquare)
            {
                Console.WriteLine(count * 2 + 1);
            }
            else Console.WriteLine(count * 2 + 2);
        }
    }
}
