using System;

namespace Lesson22___Action_Func
{
    class Program
    {
        static void Temp()
        {
            string[] numbers = Console.ReadLine().Split();
            double a = double.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            Console.WriteLine(a / b);
        }

        static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);
        }

        static double Divide()
        {
            return 5 / 2;
        }

        static double Divide1(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {   // Action(void)         Func(type)

            //  Class1 Method 1
            HandleException(Temp);

            // Class1 Method 2
            HandleException(() =>
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(array[n]);
            });

            // Class1 Method 3
            HandleException(Divide);

            // Class1 Method 4
            HandleException(Divide);

            // Class1 Method 5
            HandleException(Divide1);

        }

        static void HandleException(Func<double, double, double> function) // type no parameter
        {
            try
            {
                var result = function.Invoke(5, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void HandleException(Func<double> function) // type no parameter
        {
            try
            {
                var result = function.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void HandleException(Action<double, double> method) // Void with parameter
        {
            try
            {
                method.Invoke(5, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void HandleException(Action method)  // Void no parameter
        {
            try
            {
                method.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
