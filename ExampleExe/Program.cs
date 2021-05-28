using System;
using System.Linq;
using ExampleExe.Business;
using ExampleExe.Entities;


namespace ExampleExe
{
    class Program
    {
        static void Main(string[] args)  // Normalization  Join  inMemory-projects 
        {   // Product  Cart 
            CartManager cartManager = new CartManager(new Cart());
            cartManager.AddProduct(new Product
            {
                ProductId = 1,
                ProductName = "Aqua",
                Price = 0.5m,
                UnitsInStock = 500
            });
            cartManager.AddProduct(new Product
            {
                ProductId = 2,
                ProductName = "Sirab",
                Price = 0.6m,
                UnitsInStock = 300
            });

            cartManager.GetProducts();

            cartManager.Delete(new Product
            {
                ProductId = 3
            });

            cartManager.GetProducts();
        }
    }
}
