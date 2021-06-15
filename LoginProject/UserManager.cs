using System;
using System.Collections.Generic;

namespace LoginProject
{
    class UserManager
    {
        private Dictionary<string, string> users;

        public UserManager()
        {
            users = new Dictionary<string, string>();
        }
        public void Add(User user)
        {
            users.Add(user.UserName, user.Password);
        }

        public bool Exists(User user)
        {
            if (users.ContainsKey(user.UserName))
            {
                return true;
            }

            return false;
        }

        public bool CheckUser(User user)
        {
            if (!Exists(user))
            {
                throw new Exception();
            }

            if (user.Password == users[user.UserName])
            {
                return true;
            }

            return false;
        }

        public void Login(User user)
        {
            if (!CheckUser(user))
            {
                throw new UserNotFound("User could not found!");
            }
            Console.WriteLine($"You login successfully as {user.Person.State}");
        }
    }
}