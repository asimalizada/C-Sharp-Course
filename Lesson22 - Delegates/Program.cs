using System;

namespace Lesson22___Delegates
{
    public delegate void PrintByName(string name);

    public delegate double Operation(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            // Delegate - Action(void)  Func(type)

            //PrintByName print = new PrintByName(Printer.PrintHello);
            PrintByName print = Printer.PrintHello;

            Console.WriteLine("First invocation: ");
            print.Invoke("Asim");
            Console.WriteLine("----------");

            print += Printer.PrintWelcome;
            print += Printer.PrintBye;

            print -= Printer.PrintWelcome;

            Console.WriteLine("Second invocation: ");
            print.Invoke("Asim");

            Operation operation = (a, b) => a * b;  // 40
            operation += (a, b) => a + b; // 13

            double result = operation.Invoke(5, 8);

            Console.WriteLine(result);

        }
    }
}
