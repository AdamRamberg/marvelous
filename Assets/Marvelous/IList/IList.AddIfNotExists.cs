using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Adds an item to the IList if it doesn't already exists.
        /// </summary>
        /// <param name="list">The IList to add an item to.</param>
        /// <param name="item">The item to add.</param>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <returns>True if the item was added, otherwise false.</returns>
        public static bool AddIfNotExists<T>(IList<T> list, T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            return false;
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Adds an item to the IList if it doesn't already exists.
        /// </summary>
        /// <param name="list">The IList to add an item to.</param>
        /// <param name="item">The item to add.</param>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <returns>True if the item was added, otherwise false.</returns>
        public static bool AddIfNotExists<T>(this IList<T> list, T item)
        {
            return Marvelous.AddIfNotExists<T>(list, item);
        }
    }
}
