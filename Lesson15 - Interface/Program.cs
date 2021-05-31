namespace Lesson15___Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            EfCustomerDal efCustomerDal = new EfCustomerDal();
            efCustomerDal.Add(new CommercialCustomer());

            ICustomerDal[] customerDals = new ICustomerDal[1] { new NhCustomerDal() };
            customerDals[0].Add(new CommercialCustomer());
        }
    }
}
