using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Sets a parent of the Transform provided.
        /// </summary>
        /// <param name="transform">The Transform to set the parent on.</param>
        /// <param name="parent">The parent to add to the transform.</param>
        /// <returns>The Transform with the new parent.</returns>
        public static Transform SetParent(Transform transform, Transform parent)
        {
            transform.parent = parent;
            return transform;
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Sets a parent of the Transform provided.
        /// </summary>
        /// <param name="transform">The Transform to set the parent on.</param>
        /// <param name="parent">The parent to add to the transform.</param>
        /// <returns>The Transform with the new parent.</returns>
        public static Transform SetParent(this Transform transform, Transform parent)
        {
            return Marvelous.SetParent(transform, parent);
        }
    }
}
