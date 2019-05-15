using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Returns the first item that satisfies the condition.
        /// </summary>
        /// <param name="list">The IList to search.</param>
        /// <param name="condition">Condition to test.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <returns>The first item that satisfies the condition. If none found it returns default(T).</returns>
        public static T First<T>(IList<T> list, Func<T, bool> condition)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (condition(list[i])) return list[i];
            }

            return default(T);
        }

        /// <summary>
        /// Returns the first item that satisfies the condition.
        /// </summary>
        /// <param name="list">The IList to search.</param>
        /// <param name="condition">Condition to test.</param>
        /// <param name="param1">The 1st parameter to send to the condition.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <returns>The first item that satisfies the condition. If none found it returns default(T).</returns>
        public static T First<T, P1>(IList<T> list, Func<T, P1, bool> condition, P1 param1)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (condition(list[i], param1)) return list[i];
            }

            return default(T);
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Returns the first item that satisfies the condition.
        /// </summary>
        /// <param name="list">The IList to search.</param>
        /// <param name="condition">Condition to test.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <returns>The first item that satisfies the condition. If none found it returns default(T).</returns>
        public static T First<T>(this IList<T> list, Func<T, bool> condition)
        {
            return Marvelous.First<T>(list, condition);
        }

        /// <summary>
        /// Returns the first item that satisfies the condition.
        /// </summary>
        /// <param name="list">The IList to search.</param>
        /// <param name="condition">Condition to test.</param>
        /// <param name="param1">The 1st parameter to send to the condition.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <returns>The first item that satisfies the condition. If none found it returns default(T).</returns>
        public static T First<T, P1>(this IList<T> list, Func<T, P1, bool> condition, P1 param1)
        {
            return Marvelous.First<T, P1>(list, condition, param1);
        }
    }
}
