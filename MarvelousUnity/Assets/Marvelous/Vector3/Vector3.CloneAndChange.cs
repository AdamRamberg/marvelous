using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Create a new Vector3 based on the base Vector3, but with one axis value changed.
        /// </summary>
        /// <param name="baseV3">The base Vector3.</param>
        /// <param name="axis">The axis to change.</param>
        /// <param name="val">The new value of the axis to change.</param>
        /// <returns>A new Vector3 based on the base Vector3, but with one axis value changed.</returns>
        public static Vector3 CloneAndChange(Vector3 baseV3, V3Axis axis, float val)
        {
            return new Vector3(
                axis == V3Axis.x ? val : baseV3.x,
                axis == V3Axis.y ? val : baseV3.y,
                axis == V3Axis.z ? val : baseV3.z
            );
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Create a new Vector3 based on the base Vector3, but with one axis value changed.
        /// </summary>
        /// <param name="baseV3">The base Vector3.</param>
        /// <param name="axis">The axis to change.</param>
        /// <param name="val">The new value of the axis to change.</param>
        /// <returns>A new Vector3 based on the base Vector3, but with one axis value changed.</returns>
        public static Vector3 CloneAndChange(this Vector3 baseV3, V3Axis axis, float val)
        {
            return Marvelous.CloneAndChange(baseV3, axis, val);
        }
    }
}
