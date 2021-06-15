using System;

namespace LoginProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please, enter : ");
            Console.Write("Username : ");
            string userName = Console.ReadLine();
            Console.Write("Password : ");
            string password = Console.ReadLine();
            UserManager userManager = new UserManager();

            User user = new User
            {
                Id = 1,
                UserName = "Asim",
                Password = "Asim123",
                Person = new Customer
                {
                    Id = 1,
                    State = "Customer",
                    AccountNumber = "123456789",
                    Money = 50
                }
            };
            userManager.Add(user);

            userManager.Login(new User
            {
                Id = 1,
                UserName = userName,
                Password = password,
                Person = new Customer
                {
                    Id = 1,
                    State = "Customer",
                    AccountNumber = "123456789",
                    Money = 50
                }
            });
        }
    }
}
