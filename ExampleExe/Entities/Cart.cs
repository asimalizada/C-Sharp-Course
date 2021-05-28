using System;

namespace ExampleExe.Entities
{
    class Cart
    {
        public Cart()
        {
            Products = new Product[0];
        }

        public Product[] Products { get; set; }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (var product in Products)
                {
                    total += product.Price;
                }

                return total;
            }
        }
    }
}
