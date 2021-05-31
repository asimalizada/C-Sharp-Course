using System;

namespace Lesson12___OOP_Intro
{
    class Car
    {
        public int year;

        public decimal price;
        public string brand;
        public void Sell()
        {
            //
            //Example
            //
            Console.WriteLine($"{brand} markali {price} qiymetli masin satildi");
        }
    }
}