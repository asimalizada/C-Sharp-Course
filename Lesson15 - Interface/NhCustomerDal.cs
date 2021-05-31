using System;

namespace Lesson15___Interface
{
    class NhCustomerDal : ICustomerDal // DataAccess Layer    CRUD
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added by nh");
        }
    }
}