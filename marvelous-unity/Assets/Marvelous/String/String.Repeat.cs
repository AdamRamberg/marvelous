using System;
using System.Text;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Creates a string where the provided string is repeated the specified number of times.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="times">How many time the string provided is repeated.</param>
        /// <returns>A new string where the provided string is repeated the specified number of times.</returns>
        public string Repeat(string str, int times)
            => times == 1 ? str : new StringBuilder(str.Length * times).Insert(0, str, times).ToString();
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a string where the provided string is repeated the specified number of times.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="times">How many time the string provided is repeated.</param>
        /// <returns>A new string where the provided string is repeated the specified number of times.</returns>
        public string Repeat(this string str, int times)
        {
            return Marvelous.Repeat(str, times);
        }
    }
}
