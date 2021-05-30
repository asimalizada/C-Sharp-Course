using System;

namespace Lesson16___Constructor_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            //string currentCustomer = Console.ReadLine();
            //IProductService productService = null;
            //if (currentCustomer == "a")
            //{
            //    productService = new ProductManagerForA();
            //}
            //else if (currentCustomer == "b")
            //{
            //    productService = new ProductManagerForB();
            //}
            //productService.Add();
            //productService.Delete();
            //ProductManager productManager = new ProductManager();
            //if (currentCustomer == "a")
            //{
            //    productManager.Add(new ProductDalForA());
            //}
            //else
            //{
            //    productManager.Add(new ProductDalForB());
            //}

            //if (currentCustomer == "a")
            //{
            //    productManager.ProductDal = new ProductDalForA();
            //}
            //else
            //{
            //    productManager.ProductDal = new ProductDalForB();
            //}
            //productManager.Add();
            //productManager.Delete();
            //IProductDal productDal = null;
            //if (currentCustomer == "a")
            //{
            //    productDal = new ProductDalForA();
            //}
            //else if (currentCustomer == "b")
            //{
            //    productDal = new ProductDalForB();
            //}
            //else if (currentCustomer == "c")
            //{
            //    productDal = new ProductDalForC();
            //}
            //ProductManager productManager1 = new ProductManager(productDal);
            //productManager.Add();
            //productManager.Delete();
        }
    }
    interface IProductService
    {
        void Add();
        void Delete();
    }

    //class ProductManagerForA:IProductService
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Product Added For A");
    //    }
    //    public void Delete()
    //    {
    //        Console.WriteLine("Product Deleted For A");
    //    }
    //}
    //class ProductManagerForB : IProductService
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Product Added For B");
    //    }
    //    public void Delete()
    //    {
    //        Console.WriteLine("Product Deleted For B");
    //    }
    //}

    class ProductManager : IProductService
    {
        //property injection
        //public IProductDal ProductDal { get; set; }

        //constructor injection
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            this._productDal = productDal;
        }
        public void Add()
        {
            this._productDal.Add();
        }
        public void Delete()
        {
            this._productDal.Delete();
        }
    }


    class ProductDalForA : IProductDal
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
    class ProductDalForB : IProductDal
    {
        public void Add()
        {
            Console.WriteLine("Product Added For B");
        }
        public void Delete()
        {
            Console.WriteLine("Product Deleted For B");
        }
    }
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
    interface IProductDal
    {
        void Add();
        void Delete();
    }
}
