using System;

namespace Lesson14___Constructor
{
    public static class IntegerExtensions
    {
        public static bool IsPrimaryNumber(this Int32 number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}