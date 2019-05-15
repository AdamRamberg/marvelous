using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Calculates a new position based on the origin in the direction of the target.
        /// </summary>
        /// <param name="origin">The origin Vector2.</param>
        /// <param name="target">The target Vector2.</param>
        /// <param name="maxDistance">The max distance of the returned Vector2 from the origin.</param>
        /// <returns>The new Vector2 based on the origin in the direction of the target.</returns>
        public static Vector2 TowardsTarget(Vector2 origin, Vector2 target, float maxDistance)
        {
            var distance = target - origin;
            return origin + (distance.normalized * maxDistance);
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Calculates a new position based on the origin in the direction of the target.
        /// </summary>
        /// <param name="origin">The origin Vector2.</param>
        /// <param name="target">The target Vector2.</param>
        /// <param name="maxDistance">The max distance of the returned Vector2 from the origin.</param>
        /// <returns>The new Vector2 based on the origin in the direction of the target.</returns>
        public static Vector2 TowardsTarget(this Vector2 origin, Vector2 target, float maxDistance)
        {
            return Marvelous.TowardsTarget(origin, target, maxDistance);
        }
    }
}
