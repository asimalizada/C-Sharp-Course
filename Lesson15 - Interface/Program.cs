using System;

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
    interface ICustomerDal
    {
        void Add(Customer customer);
    }


    class EfCustomerDal : ICustomerDal  // DataAccess Layer    CRUD-> Create Read Update Delete
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added by ef");
        }
    }

    class NhCustomerDal : ICustomerDal // DataAccess Layer    CRUD
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added by nh");
        }
    }

    class Customer  // Entity  
    {
        public int Id { get; set; }

    }

    class PrivateCustomer : Customer  // Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class CommercialCustomer : Customer  // Entity
    {
        public string ContactName { get; set; }
    }
}
