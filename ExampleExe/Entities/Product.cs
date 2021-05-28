using System;
using System.Collections.Generic;

namespace ExampleExe.Entities
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
