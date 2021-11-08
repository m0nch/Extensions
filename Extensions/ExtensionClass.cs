using System;
using System.Collections.Generic;

namespace Extensions
{
    static class ExtensionClass
    {
        public static string _Reverse(this string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            value = new string(charArray);
            return value;
        }

        public static bool _IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool _IsDividedBy(this int value1, int value2)
        {
            return value1 % value2 == 0;
        }

        public static string _ConvertToString(this List<string> list)
        {
            string str = default(string);
            for (int i = 0; i < list.Count; i++)
            {
                str += list[i] + ", ";
            }
            return str;
        }
    }
}
