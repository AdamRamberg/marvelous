using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Calculates a new position based on the origin in the direction of the target.
        /// </summary>
        /// <param name="origin">The origin Vector3.</param>
        /// <param name="target">The target Vector3.</param>
        /// <param name="maxDistance">The max distance of the returned Vector3 from the origin.</param>
        /// <returns>The new Vector3 based on the origin in the direction of the target.</returns>
        public static Vector3 TowardsTarget(Vector3 origin, Vector3 target, float maxDistance)
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
        /// <param name="origin">The origin Vector3.</param>
        /// <param name="target">The target Vector3.</param>
        /// <param name="maxDistance">The max distance of the returned Vector3 from the origin.</param>
        /// <returns>The new Vector3 based on the origin in the direction of the target.</returns>
        public static Vector3 TowardsTarget(this Vector3 origin, Vector3 target, float maxDistance)
        {
            return Marvelous.TowardsTarget(origin, target, maxDistance);
        }
    }
}
