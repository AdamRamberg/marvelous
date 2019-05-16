using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Creates a pipe of all the Funcs in the IList.
        /// </summary>
        /// <param name="list">The IList containing the Func(s).</param>
        /// <typeparam name="T">The return and parameter type of the Func.</typeparam>
        /// <returns>A Func that is a pipe of all Funcs in the provided IList.</returns>
        public static Func<T, T> Pipe<T>(IList<Func<T, T>> list)
        {
            // OPEN POINT: Is it possible to make Reduce more flexible and use it here instead of this custom implementation
            return x =>
            {
                T accumulator = x;
                for (int i = 0; list != null && i < list.Count; ++i)
                {
                    accumulator = list[i](accumulator);
                }

                return accumulator;
            };
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a pipe of all the Funcs in the IList.
        /// </summary>
        /// <param name="list">The IList containing the Func(s).</param>
        /// <typeparam name="T">The return and parameter type of the Func.</typeparam>
        /// <returns>A Func that is a pipe of all Funcs in the provided IList.</returns>
        public static Func<T, T> Pipe<T>(this IList<Func<T, T>> list)
        {
            return Marvelous.Pipe<T>(list);
        }
    }
}
