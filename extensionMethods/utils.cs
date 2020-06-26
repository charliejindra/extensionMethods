using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace extensionMethods
{
    public static class utils
    {

        // put this at the first argument
        // also gotta be static
        // these are pretty cool by the way

        public static bool isEven(this int x)
        {
            return x % 2 == 0;
        }

        public static DateTime DaysFromToday(this int days)
        {
            return DateTime.Now.AddDays(days);
        }

        public static int CountVowels(this string phrase)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            return phrase
                .Where(vowels.Contains)
                .Count();
        }
    }
}
