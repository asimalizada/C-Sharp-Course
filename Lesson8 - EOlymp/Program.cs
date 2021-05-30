using System;
using System.Numerics;

namespace Lesson8___EOlymp
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = new BigInteger();
            string zeros = "";
            int y = 0;
            int z = 0;
            while (n != 0)
            {
                y = (int)(n % 10);
                if (y == 0 && z == 0)
                {
                    zeros += "0";
                }
                else
                {
                    z++;
                }

                result += y;
                n /= 10;
                if (n != 0)
                {
                    result *= 10;
                }
            }
            Console.WriteLine(zeros + result);

            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            int a = numbers[0];
            int b = numbers[1];
            int firstDigit = 0;
            int secondtDigit = 0;
            int thirdDigit = 0;

            for (int i = a; i <= b; i++)
            {
                thirdDigit = i % 10;
                secondtDigit = i / 10 % 10;
                firstDigit = i / 100;
                if (thirdDigit != secondtDigit && thirdDigit != firstDigit && firstDigit != secondtDigit)
                {
                    Console.WriteLine(i);
                }
            }
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string phoneNumber = Console.ReadLine();
            string result = "";
            foreach (var digit in digits)
            {
                if (!phoneNumber.Contains(digit))
                {
                    result += digit;
                }
            }
            Console.WriteLine(result.Length);
            Console.WriteLine(String.Join(' ', result.ToCharArray()));
        }
    }
}
