using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Convert from screen position to world position using the main camera.
        /// </summary>
        /// <param name="v2">The Vector2</param>
        /// <returns>The world position.</returns>
        public static Vector3 ToWorldPos(Vector2 v2)
        {
            return Camera.main.ScreenToWorldPoint(v2);
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Convert from screen position to world position using the main camera.
        /// </summary>
        /// <param name="v2">The Vector2</param>
        /// <returns>The world position.</returns>
        public static Vector3 ToWorldPos(this Vector2 v2)
        {
            return Marvelous.ToWorldPos(v2);
        }
    }
}
