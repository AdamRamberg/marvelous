using System;
using UnityEngine;

namespace Marvelous
{
    public static class ArrayExtensions
    {
        public static T GetRandom<T>(this T[] array)
        {
            if (array == null || array.Length <= 0)
            {
                throw new Exception("No elements in array.");
            }

            return array[UnityEngine.Random.Range(0, array.Length)];
        }
    }
}
