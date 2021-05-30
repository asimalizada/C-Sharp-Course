using System;

namespace Lesson5___EOlymp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 12;
            }
            foreach (var number in numbers)
            {
                sum += number;
            }

            string[] tokens = Console.ReadLine().Split();
            int[] numbers = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                numbers[i] = Convert.ToInt32(tokens[i]);
            }

            int n = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());
            int[,] numbers = new int[n, m];
            n = 2,m = 3

            1 2 3
            4 5 6
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    numbers[i, j] = Int32.Parse(tokens[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] tokens = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            int n = tokens[0];
            int m = tokens[1];
            int[,] numbers = new int[n, m];
            int k = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    numbers[i, j] = k;
                    k++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            int a = 5;
            int b = a++;
            int c = ++a;

            Console.WriteLine($"a={a},b={b},c={c}");


            int n = Int32.Parse(Console.ReadLine());
            int length = (int)Math.Log(n, 2) + 1;
            int[] binary = new int[length];
            for (int i = 0; n != 0; i++, n /= 2)
            {
                binary[i] = n % 2;
            }

            Array.Reverse(binary);

            Console.WriteLine(String.Join(' ', binary));

            string reverseBinary = "";
            while (n != 0)
            {
                reverseBinary += n % 2;
                n /= 2;
            }
            int[] binary = new int[reverseBinary.Length];

            for (int i = 0; i < reverseBinary.Length; i++)
            {
                binary[i] = Convert.ToInt32(reverseBinary[binary.GetUpperBound(0) - i].ToString());
            }

            Console.WriteLine(String.Join(' ', binary));


            char[] charReverseBinary = reverseBinary.ToCharArray();

            Array.Reverse(charReverseBinary);

            string binary = new string(charReverseBinary);

            Console.WriteLine(binary);
        }
    }
}
