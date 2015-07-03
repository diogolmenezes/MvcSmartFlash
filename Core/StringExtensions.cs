using System;

namespace MvcSmartFlash.Core
{
    public static class StringExtensions
    {
        public static bool HasValue(this string value)
        {
            return !String.IsNullOrEmpty(value);
        }

        public static bool DoesNotHasValue(this string value)
        {
            return !HasValue(value);
        }
    }
}
