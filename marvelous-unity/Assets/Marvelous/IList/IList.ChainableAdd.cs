using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Adds an item to the IList and then returns the IList.
        /// </summary>
        /// <param name="list">The IList to add the item to.</param>
        /// <param name="item">The item to add.</param>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <returns>The IList.</returns>
        public static IList<T> ChainableAdd<T>(IList<T> list, T item)
        {
            list.Add(item);
            return list;
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Adds an item to the IList and then returns the IList.
        /// </summary>
        /// <param name="list">The IList to add the item to.</param>
        /// <param name="item">The item to add.</param>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <returns>The IList.</returns>
        public static IList<T> ChainableAdd<T>(this IList<T> list, T item)
        {
            return Marvelous.ChainableAdd<T>(list, item);
        }
    }
}
