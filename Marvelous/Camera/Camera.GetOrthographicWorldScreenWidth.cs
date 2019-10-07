using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Get the camera's viewport world width.
        /// </summary>
        /// <param name="camera">The camera.</param>
        /// <returns>The width.</returns>
        /// <exception cref="System.Exception">Thrown if the camera is not orthographic.</exception>
        public static float GetOrthographicWorldScreenWidth(Camera camera)
        {
            if (!camera.orthographic)
            {
                throw new Exception("Camera must be orthographic.");
            }

            return Marvelous.GetOrthographicWorldScreenHeight(camera) / Screen.height * Screen.width;
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Get the camera's viewport world width.
        /// </summary>
        /// <param name="camera">The camera.</param>
        /// <returns>The width.</returns>
        /// <exception cref="System.Exception">Thrown if the camera is not orthographic.</exception>
        public static float GetOrthographicWorldScreenWidth(this Camera camera)
        {
            return Marvelous.GetOrthographicWorldScreenWidth(camera);
        }
    }
}
