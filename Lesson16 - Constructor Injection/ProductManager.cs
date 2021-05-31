namespace Lesson16___Constructor_Injection
{
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
}