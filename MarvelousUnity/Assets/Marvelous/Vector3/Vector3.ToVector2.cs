using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Creates a Vector2 from a Vector3.
        /// </summary>
        /// <param name="v3">The Vector3.</param>
        /// <returns>A new Vector3 based on the Vector2.</returns>
        public static Vector2 ToVector2(Vector2 v3)
        {
            return new Vector2(v3.x, v3.y);
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a Vector2 from a Vector3.
        /// </summary>
        /// <param name="v3">The Vector3.</param>
        /// <returns>A new Vector3 based on the Vector2.</returns>
        public static Vector2 ToVector2(this Vector2 v3)
        {
            return Marvelous.ToVector2(v3);
        }
    }
}
