using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Performs an action on each item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        public static void ForEach<T, P1>(IList<T> list, Action<T, P1> action, P1 param1)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], param1);
            }
        }

        /// <summary>
        /// Performs an action on each item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        public static void ForEach<T, P1, P2>(IList<T> list, Action<T, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], param1, param2);
            }
        }

        /// <summary>
        /// Performs an action on each item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <param name="param3">The 3rd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        /// <typeparam name="P3">The param3 type.</typeparam>
        public static void ForEach<T, P1, P2, P3>(IList<T> list, Action<T, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], param1, param2, param3);
            }
        }

        /// <summary>
        /// Performs an action on each selected item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="selector">Func that selects V from the list item that will be passed to the Action</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="V">The type returned by the selector.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        public static void ForEach<T, V, P1>(IList<T> list, Func<T, V> selector, Action<V, P1> action, P1 param1)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(selector(list[i]), param1);
            }
        }

        /// <summary>
        /// Performs an action on each selected item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="selector">Func that selects V from the list item that will be passed to the Action</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="V">The type returned by the selector.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        public static void ForEach<T, V, P1, P2>(IList<T> list, Func<T, V> selector, Action<V, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(selector(list[i]), param1, param2);
            }
        }

        /// <summary>
        /// Performs an action on each selected item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="selector">Func that selects V from the list item that will be passed to the Action</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <param name="param3">The 3rd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="V">The type returned by the selector.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        /// <typeparam name="P3">The param3 type.</typeparam>
        public static void ForEach<T, V, P1, P2, P3>(IList<T> list, Func<T, V> selector, Action<V, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(selector(list[i]), param1, param2, param3);
            }
        }

        /// <summary>
        /// Performs an action on each item in the list passing item index and parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        public static void ForEach<T>(IList<T> list, Action<T, int> action)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], i);
            }
        }

        /// <summary>
        /// Performs an action on each item in the list passing item index and parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        public static void ForEach<T, P1>(IList<T> list, Action<T, int, P1> action, P1 param1)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], i, param1);
            }
        }

        /// <summary>
        /// Performs an action on each item in the list passing item index and parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        public static void ForEach<T, P1, P2>(IList<T> list, Action<T, int, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], i, param1, param2);
            }
        }

        /// <summary>
        /// Performs an action on each item in the list passing item index and parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <param name="param3">The 3rd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        /// <typeparam name="P3">The param3 type.</typeparam>
        public static void ForEach<T, P1, P2, P3>(IList<T> list, Action<T, int, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; list != null && i < list.Count; ++i)
            {
                action(list[i], i, param1, param2, param3);
            }
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Performs an action on each item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        public static void ForEach<T, P1>(this IList<T> list, Action<T, P1> action, P1 param1)
        {
            Marvelous.ForEach<T, P1>(list, action, param1);
        }

        /// <summary>
        /// Performs an action on each item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        public static void ForEach<T, P1, P2>(this IList<T> list, Action<T, P1, P2> action, P1 param1, P2 param2)
        {
            Marvelous.ForEach<T, P1, P2>(list, action, param1, param2);
        }

        /// <summary>
        /// Performs an action on each item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <param name="param3">The 3rd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        /// <typeparam name="P3">The param3 type.</typeparam>
        public static void ForEach<T, P1, P2, P3>(this IList<T> list, Action<T, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            Marvelous.ForEach<T, P1, P2, P3>(list, action, param1, param2, param3);
        }

        /// <summary>
        /// Performs an action on each selected item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="selector">Func that selects V from the list item that will be passed to the Action</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="V">The type returned by the selector.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        public static void ForEach<T, V, P1>(this IList<T> list, Func<T, V> selector, Action<V, P1> action, P1 param1)
        {
            Marvelous.ForEach<T, V, P1>(list, selector, action, param1);
        }

        /// <summary>
        /// Performs an action on each selected item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="selector">Func that selects V from the list item that will be passed to the Action</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="V">The type returned by the selector.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        public static void ForEach<T, V, P1, P2>(this IList<T> list, Func<T, V> selector, Action<V, P1, P2> action, P1 param1, P2 param2)
        {
            Marvelous.ForEach<T, V, P1, P2>(list, selector, action, param1, param2);
        }

        /// <summary>
        /// Performs an action on each selected item in the list passing parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="selector">Func that selects V from the list item that will be passed to the Action</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <param name="param3">The 3rd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="V">The type returned by the selector.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        /// <typeparam name="P3">The param3 type.</typeparam>
        public static void ForEach<T, V, P1, P2, P3>(this IList<T> list, Func<T, V> selector, Action<V, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            Marvelous.ForEach<T, V, P1, P2, P3>(list, selector, action, param1, param2, param3);
        }

        /// <summary>
        /// Performs an action on each item in the list passing item index and parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        public static void ForEach<T>(this IList<T> list, Action<T, int> action)
        {
            Marvelous.ForEach<T>(list, action);
        }

        /// <summary>
        /// Performs an action on each item in the list passing item index and parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        public static void ForEach<T, P1>(this IList<T> list, Action<T, int, P1> action, P1 param1)
        {
            Marvelous.ForEach<T, P1>(list, action, param1);
        }

        /// <summary>
        /// Performs an action on each item in the list passing item index and parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        public static void ForEach<T, P1, P2>(this IList<T> list, Action<T, int, P1, P2> action, P1 param1, P2 param2)
        {
            Marvelous.ForEach<T, P1, P2>(list, action, param1, param2);
        }

        /// <summary>
        /// Performs an action on each item in the list passing item index and parameter(s) to the action.
        /// </summary>
        /// <param name="list">The IList to iterate over.</param>
        /// <param name="action">The action to be executed.</param>
        /// <param name="param1">The 1st parameter to send to the action.</param>
        /// <param name="param2">The 2nd parameter to send to the action.</param>
        /// <param name="param3">The 3rd parameter to send to the action.</param>
        /// <typeparam name="T">The type of the items.</typeparam>
        /// <typeparam name="P1">The param1 type.</typeparam>
        /// <typeparam name="P2">The param2 type.</typeparam>
        /// <typeparam name="P3">The param3 type.</typeparam>
        public static void ForEach<T, P1, P2, P3>(this IList<T> list, Action<T, int, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            Marvelous.ForEach<T, P1, P2, P3>(list, action, param1, param2, param3);
        }
    }
}
