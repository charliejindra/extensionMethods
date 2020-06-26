using System;
using System.Collections.Generic;
using System.Text;

namespace extensionMethods
{
    public class methodExamples
    {

        public string FormatName(string first, string last)
        {
            return last + ", " + first;
        }

        public string FormatName(string first, string middle, string last)
        {
            return $"{last}, {first} {middle}.";
        }

    }
}
