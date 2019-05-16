using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Finds a child to this transform by name. Searches not only the first level in the
        /// tree hierarchy of child objects, but all the children, grand children, and so on.
        /// </summary>
        /// <param name="parent">The parent Transform to perform the search on.</param>
        /// <param name="name">The name to look for.</param>
        /// <returns>The child transform by the name specified. Returns null if no child was found.</returns>
        public static Transform FindDeepChild(Transform parent, string name)
        {
            var result = parent.Find(name);

            if (result != null)
                return result;

            for (int i = 0; i < parent.childCount; ++i)
            {
                result = FindDeepChild(parent.GetChild(i), name);
                if (result != null)
                    return result;
            }

            return null;
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Finds a child to this transform by name. Searches not only the first level in the
        /// tree hierarchy of child objects, but all the children, grand children, and so on.
        /// </summary>
        /// <param name="parent">The parent Transform to perform the search on.</param>
        /// <param name="name">The name to look for.</param>
        /// <returns>The child transform by the name specified. Returns null if no child was found.</returns>
        public static Transform FindDeepChild(this Transform parent, string name)
        {
            return Marvelous.FindDeepChild(parent, name);
        }
    }
}
