using System;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Tries to convert a string to an int.
        /// </summary>
        /// <param name="str">The string to convert.</param>
        /// <param name="def">The default value returned if it not possible to convert the string.</param>
        /// <returns>The string converted as an integer.</returns>
        public int ToInt(string str, int def = 0)
        {
            int num;
            return int.TryParse(str, out num) ? num : def;
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Tries to convert a string to an int.
        /// </summary>
        /// <param name="str">The string to convert.</param>
        /// <param name="def">The default value returned if it not possible to convert the string.</param>
        /// <returns>The string converted as an integer.</returns>
        public static int ToInt(this string str, int def)
        {
            return Marvelous.ToInt(str, def);
        }
    }
}
