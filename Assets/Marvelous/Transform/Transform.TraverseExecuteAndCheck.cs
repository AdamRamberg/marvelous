using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Traverse all the children of the transform and executes the Func on this transform,
        /// as well as on all the children.
        /// </summary>
        /// <param name="current">The current Transform to execute the Func on.</param>
        /// <param name="func">The Func to executed.</param>
        /// <returns>True if all of the funcs returns true, otherwise false.</returns>
        public static bool TraverseExecuteAndCheck(Transform current, Func<Transform, bool> func)
        {
            bool ret = func(current);

            for (int i = 0; i < current.childCount; ++i)
            {
                var temp = TraverseExecuteAndCheck(current.GetChild(i), func);
                if (!temp)
                    ret = false;
            }

            return ret;
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Traverse all the children of the transform and executes the Func on this transform,
        /// as well as on all the children.
        /// </summary>
        /// <param name="current">The current Transform to execute the Func on.</param>
        /// <param name="func">The Func to executed.</param>
        /// <returns>True if all of the funcs returns true, otherwise false.</returns>
        public static bool TraverseExecuteAndCheck(this Transform current, Func<Transform, bool> func)
        {
            return Marvelous.TraverseExecuteAndCheck(current, func);
        }
    }
}
