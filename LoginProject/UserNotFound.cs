using System;

namespace LoginProject
{
    class UserNotFound : Exception
    {
        public UserNotFound(string message) : base(message)
        {

        }
    }
}