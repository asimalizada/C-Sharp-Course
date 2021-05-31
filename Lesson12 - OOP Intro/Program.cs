using System;

namespace Lesson12___OOP_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            ////abstraction
            ////encapsulation
            ////inheritance
            ////polimorfizm
            Car car = new Car();
            //deyerleri set edirem
            car.year = 2010;
            car.price = 20000;
            car.price = 30000;
            car.brand = "Hundai";
            //deyerleri get edirem
            Console.WriteLine(car.brand);
            Console.WriteLine(car.year);
            Console.WriteLine(car.price);
            car.Sell();
            Car car2 = new Car();
            car2.price = 20000;
            car2.brand = "BMV";
            car2.Sell();


            Credit credt = new Credit();
            credt.Percent = 10;
            credt.InitialPrice = 200;
            credt.Customer = "Ramiz";
            Console.WriteLine(credt.GetPrice());
            //credt.SetPrice(1000);
            credt.GiveCredit();
            //credt.Price = 1000;
        }
    }
}
