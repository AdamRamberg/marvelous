using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Iterates over all the children and executes the Action specified.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        public static void ForEachChild(Transform transform, Action<Transform> action)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i));
            }
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        public static void ForEachChild<P1>(Transform transform, Action<Transform, P1> action, P1 param1)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), param1);
            }
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <param name="param2">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        /// <typeparam name="P2">Type of param2.</typeparam>
        public static void ForEachChild<P1, P2>(Transform transform, Action<Transform, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), param1, param2);
            }
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <param name="param2">Parameter sent to the Action.</param>
        /// <param name="param3">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        /// <typeparam name="P2">Type of param2.</typeparam>
        /// <typeparam name="P3">Type of param3.</typeparam>
        public static void ForEachChild<P1, P2, P3>(Transform transform, Action<Transform, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), param1, param2, param3);
            }
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified. Action will get passed the child's index.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        public static void ForEachChild(Transform transform, Action<Transform, int> action)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), i);
            }
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified. Action will get passed the child's index.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        public static void ForEachChild<P1>(Transform transform, Action<Transform, int, P1> action, P1 param1)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), i, param1);
            }
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified. Action will get passed the child's index.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <param name="param2">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        /// <typeparam name="P2">Type of param2.</typeparam>
        public static void ForEachChild<P1, P2>(Transform transform, Action<Transform, int, P1, P2> action, P1 param1, P2 param2)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), i, param1, param2);
            }
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified. Action will get passed the child's index.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <param name="param2">Parameter sent to the Action.</param>
        /// <param name="param3">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        /// <typeparam name="P2">Type of param2.</typeparam>
        /// <typeparam name="P3">Type of param3.</typeparam>
        public static void ForEachChild<P1, P2, P3>(Transform transform, Action<Transform, int, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                action(transform.GetChild(i), i, param1, param2, param3);
            }
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Iterates over all the children and executes the Action specified.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        public static void ForEachChild(this Transform transform, Action<Transform> action)
        {
            Marvelous.ForEachChild(transform, action);
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        public static void ForEachChild<P1>(this Transform transform, Action<Transform, P1> action, P1 param1)
        {
            Marvelous.ForEachChild(transform, action, param1);
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <param name="param2">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        /// <typeparam name="P2">Type of param2.</typeparam>
        public static void ForEachChild<P1, P2>(this Transform transform, Action<Transform, P1, P2> action, P1 param1, P2 param2)
        {
            Marvelous.ForEachChild(transform, action, param1, param2);
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <param name="param2">Parameter sent to the Action.</param>
        /// <param name="param3">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        /// <typeparam name="P2">Type of param2.</typeparam>
        /// <typeparam name="P3">Type of param3.</typeparam>
        public static void ForEachChild<P1, P2, P3>(this Transform transform, Action<Transform, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            Marvelous.ForEachChild(transform, action, param1, param2, param3);
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified. Action will get passed the child's index.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        public static void ForEachChild(this Transform transform, Action<Transform, int> action)
        {
            Marvelous.ForEachChild(transform, action);
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified. Action will get passed the child's index.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        public static void ForEachChild<P1>(this Transform transform, Action<Transform, int, P1> action, P1 param1)
        {
            Marvelous.ForEachChild(transform, action, param1);
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified. Action will get passed the child's index.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <param name="param2">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        /// <typeparam name="P2">Type of param2.</typeparam>
        public static void ForEachChild<P1, P2>(this Transform transform, Action<Transform, int, P1, P2> action, P1 param1, P2 param2)
        {
            Marvelous.ForEachChild(transform, action, param1, param2);
        }

        /// <summary>
        /// Iterates over all the children and executes the Action specified. Action will get passed the child's index.
        /// </summary>
        /// <param name="transform">The Transform with the children to iterate.</param>
        /// <param name="action">The Action to be executed.</param>
        /// <param name="param1">Parameter sent to the Action.</param>
        /// <param name="param2">Parameter sent to the Action.</param>
        /// <param name="param3">Parameter sent to the Action.</param>
        /// <typeparam name="P1">Type of param1.</typeparam>
        /// <typeparam name="P2">Type of param2.</typeparam>
        /// <typeparam name="P3">Type of param3.</typeparam>
        public static void ForEachChild<P1, P2, P3>(Transform transform, Action<Transform, int, P1, P2, P3> action, P1 param1, P2 param2, P3 param3)
        {
            Marvelous.ForEachChild(transform, action, param1, param2, param3);
        }
    }
}
