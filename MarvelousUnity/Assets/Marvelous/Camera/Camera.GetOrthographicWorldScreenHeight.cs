using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Get the camera's viewport world height.
        /// </summary>
        /// <param name="camera">The camera.</param>
        /// <returns>The height.</returns>
        /// <exception cref="System.Exception">Thrown if the camera is not orthographic.</exception>
        public static float GetOrthographicWorldScreenHeight(Camera camera)
        {
            if (!camera.orthographic)
            {
                throw new Exception("Camera must be orthographic.");
            }

            return camera.orthographicSize * 2f;
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Get the camera's viewport world height.
        /// </summary>
        /// <param name="camera">The camera.</param>
        /// <returns>The height.</returns>
        /// <exception cref="System.Exception">Thrown if the camera is not orthographic.</exception>
        public static float GetOrthographicWorldScreenHeight(this Camera camera)
        {
            return Marvelous.GetOrthographicWorldScreenHeight(camera);
        }
    }
}
