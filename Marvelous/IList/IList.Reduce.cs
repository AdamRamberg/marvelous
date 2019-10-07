using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// The Reduce method executes a reducer function (that you provide) on each element of the IList, resulting in a single output value.
        /// </summary>
        /// <param name="list">The IList to reduce.</param>
        /// <param name="reducer">Reducer Func.</param>
        /// <param name="getValue">Func to retrieve value that gets passed to the reducer.</param>
        /// <param name="initialValue">Initial value of the accumulator.</param>
        /// <param name="skip">If provided and true, skip the examined item.</param>
        /// <typeparam name="R">Return type.</typeparam>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <returns>A reduced value of type R.</returns>
        public static R Reduce<R, T>(IList<T> list, Func<R, R, R> reducer, Func<T, R> getValue, R initialValue, Func<T, bool> skip = null)
        {
            R accumulator = initialValue;
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (skip != null && skip(list[i]))
                {
                    continue;
                }

                accumulator = reducer(accumulator, getValue(list[i]));
            }

            return accumulator;
        }

        /// <summary>
        /// The Reduce method executes a reducer function (that you provide) on each element of the IList, resulting in a single output value.
        /// </summary>
        /// <param name="list">The IList to reduce.</param>
        /// <param name="reducer">Reducer Func.</param>
        /// <param name="getValue">Func to retrieve value that gets passed to the reducer.</param>
        /// <param name="initialValue">Initial value of the accumulator.</param>
        /// <param name="reducerParam1">The 1st parameter to send to the reducer.</param>
        /// <param name="skip">If provided and true, skip the examined item.</param>
        /// <typeparam name="R">Return type.</typeparam>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">Type of reducerParam1.</typeparam>
        /// <returns>A reduced value of type R.</returns>
        public static R Reduce<R, T, P1>(IList<T> list, Func<R, R, P1, R> reducer, Func<T, R> getValue, R initialValue, P1 reducerParam1, Func<T, bool> skip = null)
        {
            R accumulator = initialValue;
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                if (skip != null && skip(list[i]))
                {
                    continue;
                }

                accumulator = reducer(accumulator, getValue(list[i]), reducerParam1);
            }

            return accumulator;
        }

        /// <summary>
        /// A reducer that returns the maximum float.
        /// </summary>
        /// <param name="acc">The accumulator.</param>
        /// <param name="cur">The current value.</param>
        /// <returns>The maximum float value.</returns>
        public static float ReturnMaxFloatReducer(float acc, float cur) { return Mathf.Max(acc, cur); }

        /// <summary>
        /// A reducer that returns the minimum float.
        /// </summary>
        /// <param name="acc">The accumulator.</param>
        /// <param name="cur">The current value.</param>
        /// <returns>The minimum float value.</returns>
        public static float ReturnMinFloatReducer(float acc, float cur) { return Mathf.Min(acc, cur); }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// The Reduce method executes a reducer function (that you provide) on each element of the IList, resulting in a single output value.
        /// </summary>
        /// <param name="list">The IList to reduce.</param>
        /// <param name="reducer">Reducer Func.</param>
        /// <param name="getValue">Func to retrieve value that gets passed to the reducer.</param>
        /// <param name="initialValue">Initial value of the accumulator.</param>
        /// <param name="skip">If provided and true, skip the examined item.</param>
        /// <typeparam name="R">Return type.</typeparam>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <returns>A reduced value of type R.</returns>
        public static R Reduce<R, T>(this IList<T> list, Func<R, R, R> reducer, Func<T, R> getValue, R initialValue, Func<T, bool> skip = null)
        {
            return Marvelous.Reduce<R, T>(list, reducer, getValue, initialValue, skip);
        }

        /// <summary>
        /// The Reduce method executes a reducer function (that you provide) on each element of the IList, resulting in a single output value.
        /// </summary>
        /// <param name="list">The IList to reduce.</param>
        /// <param name="reducer">Reducer Func.</param>
        /// <param name="getValue">Func to retrieve value that gets passed to the reducer.</param>
        /// <param name="initialValue">Initial value of the accumulator.</param>
        /// <param name="reducerParam1">The 1st parameter to send to the reducer.</param>
        /// <param name="skip">If provided and true, skip the examined item.</param>
        /// <typeparam name="R">Return type.</typeparam>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">Type of reducerParam1.</typeparam>
        /// <returns>A reduced value of type R.</returns>
        public static R Reduce<R, T, P1>(this IList<T> list, Func<R, R, P1, R> reducer, Func<T, R> getValue, R initialValue, P1 reducerParam1, Func<T, bool> skip = null)
        {
            return Marvelous.Reduce<R, T, P1>(list, reducer, getValue, initialValue, reducerParam1, skip);
        }
    }
}
