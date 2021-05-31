using System;

namespace Lesson16___Constructor_Injection
{
    class ProductManagerForA : IProductService
    {
        public void Add()
        {
            Console.WriteLine("Product Added For A");
        }
        public void Delete()
        {
            Console.WriteLine("Product Deleted For A");
        }
    }
}