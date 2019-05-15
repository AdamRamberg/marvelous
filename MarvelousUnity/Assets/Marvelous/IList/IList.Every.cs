using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// The Every method tests whether all elements in the array pass the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to test.</param>
        /// <param name="func">The Func that implements the test.</param>
        /// <typeparam name="T">The type of the items in the IList.</typeparam>
        /// <returns>True if all elements in the IList passes the test, otherwise false.</returns>
        public static bool Every<T>(List<T> list, Func<T, bool> func)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (!func(list[i])) return false;
            }

            return true;
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// The Every method tests whether all elements in the array pass the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to test.</param>
        /// <param name="func">The Func that implements the test.</param>
        /// <typeparam name="T">The type of the items in the IList.</typeparam>
        /// <returns>True if all elements in the IList passes the test, otherwise false.</returns>
        public static bool Every<T>(this List<T> list, Func<T, bool> func)
        {
            return Marvelous.Every<T>(list, func);
        }
    }
}
