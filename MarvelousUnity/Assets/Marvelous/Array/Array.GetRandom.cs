using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Get a random item from the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <typeparam name="T">Type of array.</typeparam>
        /// <returns>Random item from array.</returns>
        /// <exception cref="System.Exception">Thrown if array is null or empty.</exception>
        public static T GetRandom<T>(T[] array)
        {
            if (array == null || array.Length <= 0)
            {
                throw new Exception("No elements in array.");
            }

            return array[UnityEngine.Random.Range(0, array.Length)];
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Get a random item from the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <typeparam name="T">Type of array.</typeparam>
        /// <returns>Random item from array.</returns>
        /// <exception cref="System.Exception">Thrown if array is null or empty.</exception>
        public static T GetRandom<T>(this T[] array)
        {
            return Marvelous.GetRandom<T>(array);
        }
    }
}
