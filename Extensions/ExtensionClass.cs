using System;
using System.Collections.Generic;

namespace Extensions
{
    static class ExtensionClass
    {
        /// <summary>
        ///Reverses characters in a given string
        /// </summary>
        /// <param name="value">given any string value</param>
        /// <returns>string value</returns>
        public static string _Reverse(this string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            value = new string(charArray);
            return value;
        }

        /// <summary>
        /// Checks if a given number is even
        /// </summary>
        /// <param name="value">given any Int32 value</param>
        /// <returns>true or false</returns>
        public static bool _IsEven(this int value)
        {
            return value % 2 == 0;
        }

        /// <summary>
        /// Checks if a given two number is divided without remainder
        /// </summary>
        /// <param name="value1">given any Int32 value</param>
        /// <param name="value2">given any Int32 value</param>
        /// <returns>true or false</returns>
        public static bool _IsDividedBy(this int value1, int value2)
        {
            return value1 % value2 == 0;
        }

        /// <summary>
        /// Converts given list to string
        /// </summary>
        /// <param name="list">given any List</param>
        /// <returns>string value</returns>
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
