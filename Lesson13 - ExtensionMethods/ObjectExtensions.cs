using System;

namespace Lesson13___ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static int ToInt(this object @object)
        {
            return Convert.ToInt32(@object);
        }
        public static int Multy(this Emeliyatlar emeliyatlar, int a, int b)
        {
            return a * b;
        }
    }
}