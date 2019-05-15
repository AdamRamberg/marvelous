using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// The Some method tests whether at least one element in the IList passes the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to test.</param>
        /// <param name="func">The Func that implements the test.</param>
        /// <typeparam name="T">The type of the items in the IList.</typeparam>
        /// <returns>True if at least one element in the IList passes the test, otherwise false.</returns>
        public static bool Some<T>(IList<T> list, Func<T, bool> func)
        {
            return !EqualityComparer<T>.Default.Equals(list.First(func), default(T));
        }

        /// <summary>
        /// The Some method tests whether at least one element in the IList passes the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to test.</param>
        /// <param name="func">The Func that implements the test.</param>
        /// <param name="param1">The 1st parameter to send to the Func.</param>
        /// <typeparam name="T">The type of the items in the IList.</typeparam>
        /// <typeparam name="P1">The type of param1.</typeparam>
        /// <returns>True if at least one element in the IList passes the test, otherwise false.</returns>
        public static bool Some<T, P1>(IList<T> list, Func<T, P1, bool> func, P1 param1)
        {
            return !EqualityComparer<T>.Default.Equals(list.First(func, param1), default(T));
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// The Some method tests whether at least one element in the IList passes the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to test.</param>
        /// <param name="func">The Func that implements the test.</param>
        /// <typeparam name="T">The type of the items in the IList.</typeparam>
        /// <returns>True if at least one element in the IList passes the test, otherwise false.</returns>
        public static bool Some<T>(this IList<T> list, Func<T, bool> func)
        {
            return Marvelous.Some<T>(list, func);
        }

        /// <summary>
        /// The Some method tests whether at least one element in the IList passes the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to test.</param>
        /// <param name="func">The Func that implements the test.</param>
        /// <param name="param1">The 1st parameter to send to the Func.</param>
        /// <typeparam name="T">The type of the items in the IList.</typeparam>
        /// <typeparam name="P1">The type of param1.</typeparam>
        /// <returns>True if at least one element in the IList passes the test, otherwise false.</returns>
        public static bool Some<T, P1>(this IList<T> list, Func<T, P1, bool> func, P1 param1)
        {
            return Marvelous.Some<T, P1>(list, func, param1);
        }
    }
}
