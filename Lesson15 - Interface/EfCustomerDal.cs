using System;

namespace Lesson15___Interface
{
    class EfCustomerDal : ICustomerDal  // DataAccess Layer    CRUD-> Create Read Update Delete
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added by ef");
        }
    }
}