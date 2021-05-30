using System;

namespace Lesson4___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);

            string[] tokens = Console.ReadLine().Split();
            int[] numbers = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                numbers[i] = Convert.ToInt32(tokens[i]);
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);



            for (int i = 1; i < n; i += 2)
            {
                if (i == 11)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);
            }
            int n = Int32.Parse(Console.ReadLine());

            int sumOfOddNumbers = 0;
            int sumOfEvenNumbers = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sumOfEvenNumbers += i;
                }
                else
                {
                    sumOfOddNumbers += 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sumOfEvenNumbers += i;
                }
                else
                {
                    sumOfOddNumbers += 1;
                }
            }

            for (int i = 0; i <= n; i += 2)
            {
                sumOfEvenNumbers += i;
                sumOfOddNumbers += i + 1;
            }
            if (n % 2 == 0)
            {
                sumOfOddNumbers -= n + 1;
            }
            int j = 1;
            for (int i = 0; i < n; i += 2, j += 2)
            {
                sumOfEvenNumbers += i;
                sumOfOddNumbers += j;
            }

            int i = 1;
            int sum = 0;
            while (i < n)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);

            int sum = 0;
            while (true)
            {
                int number = Int32.Parse(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                sum += number;
            }
            Console.WriteLine("Daxil edilen reqemlerin cemi= " + sum);

            int number;
            do
            {
                number = Int32.Parse(Console.ReadLine());
            }
            while (number != -1);
        }
    }
}
