using System;
using System.Collections.Generic;

namespace Lesson20___Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics

            object data;  // boxing    implicit casting

            ShowData<int>(5);

            Temp(5);

            List<int> numbers = new List<int>();
            //numbers.Add("c");

            Storage storage = new Storage
            {
                DataId = 1,
                Data = "K201"
            };

            DataStorage<Product> dataStorage = new DataStorage<Product>
            {
                DataId = 1,
                Data = new Product() // 5 versək, error
            };


        }
        static void ShowData<T>(T data)  // Type
        {
            Console.WriteLine(data);
        }

        static void Temp(object data)
        {
            Console.WriteLine(data);
        }
        //static void Temp(int data)
        //{
        //    Console.WriteLine(data);
        //}
        //static void Temp(string data)
        //{
        //    Console.WriteLine(data);
        //}
        //static void Temp(double data)
        //{
        //    Console.WriteLine(data);
        //}
        //static void Temp(Product data)
        //{
        //    Console.WriteLine(data);
        //}


    }

    class Storage
    {
        public int DataId { get; set; }
        public object Data { get; set; }
    }

    class DataStorage<T> where T : class, IEntity, new() // generic constraints
    {
        public int DataId { get; set; }
        public T Data { get; set; }
    }

    interface IEntity
    {

    }

    class Product : IEntity
    {

    }

}
