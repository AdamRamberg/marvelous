using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Creates a Vector3 from a Vector2.
        /// </summary>
        /// <param name="v2">The Vector2.</param>
        /// <param name="z">The z-value of the new Vector3.</param>
        /// <returns>A new Vector3 based on the Vector2.</returns>
        public static Vector3 ToVector3(Vector2 v2, float z = 0f)
        {
            return new Vector3(v2.x, v2.y, z);
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a Vector3 from a Vector2.
        /// </summary>
        /// <param name="v2">The Vector2.</param>
        /// <param name="z">The z-value of the new Vector3.</param>
        /// <returns>A new Vector3 based on the Vector2.</returns>
        public static Vector3 ToVector3(this Vector2 v2, float z = 0f)
        {
            return Marvelous.ToVector3(v2, z);
        }
    }
}
