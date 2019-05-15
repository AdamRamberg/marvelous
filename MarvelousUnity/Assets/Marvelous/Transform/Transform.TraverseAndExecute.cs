using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Traverse all the children of the transform and executes the Action on this transform,
        /// as well as on all the children recursively.
        /// </summary>
        /// <param name="current">The current Transform to execute the Action on.</param>
        /// <param name="action">The Action to executed.</param>
        public static void TraverseAndExecute(Transform current, Action<Transform> action)
        {
            action(current);

            for (int i = 0; i < current.childCount; ++i)
            {
                TraverseAndExecute(current.GetChild(i), action);
            }
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Traverse all the children of the transform and executes the Action on this transform,
        /// as well as on all the children recursively.
        /// </summary>
        /// <param name="current">The current Transform to execute the Action on.</param>
        /// <param name="action">The Action to executed.</param>
        public static void TraverseAndExecute(this Transform current, Action<Transform> action)
        {
            Marvelous.TraverseAndExecute(current, action);
        }
    }
}
