using System.Linq;

namespace Lesson14___Constructor
{
    public static class StringExtensions
    {
        public static bool IsCorrectPhoneNumber(this string str)
        {
            //number +994 5 527 13 66
            string[] inceptions = { "50", "51", "55", "70", "77", "99" };
            if (str.Substring(0, 4) == "+994" && str.Length == 13 && inceptions.Contains(str.Substring(4, 2)))
            {
                return true;
            }

            return false;
        }
    }
}