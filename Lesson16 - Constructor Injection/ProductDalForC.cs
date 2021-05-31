using System;

namespace Lesson16___Constructor_Injection
{
    class ProductDalForC : IProductDal
    {
        public void Add()
        {
            Console.WriteLine("Product Added For C");
        }
        public void Delete()
        {
            Console.WriteLine("Product Deleted For C");
        }
    }
}