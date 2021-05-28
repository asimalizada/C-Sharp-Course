using ExampleExe.Entities;
using System;
using System.Collections.Generic;


namespace ExampleExe.Business
{
    class CartManager
    {
        private Cart _cart;

        public CartManager(Cart cart)
        {
            _cart = cart;
        }
        public void GetProducts()
        {
            foreach (var product in _cart.Products)
            {
                Console.Write(product.ProductName + " ");
            }
            Console.Write(_cart.TotalPrice + "\n");
        }
        public void AddProduct(Product product)
        {
            var products = _cart.Products; 
            _cart.Products = new Product[_cart.Products.Length + 1]; 
            for (int i = 0; i < _cart.Products.Length - 1; i++)
            {
                _cart.Products[i] = products[i];
            }

            _cart.Products[_cart.Products.GetUpperBound(0)] = product;
        }

        public void Delete(Product product)
        {
            var products = _cart.Products; // 6
            _cart.Products = new Product[_cart.Products.Length - 1]; // 5
            int temp = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductId == product.ProductId) continue;
                _cart.Products[temp] = products[i];
                temp++;
            }
        }

    }
}
