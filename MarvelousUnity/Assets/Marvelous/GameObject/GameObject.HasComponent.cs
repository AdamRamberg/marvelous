using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Check if a GameObject has a component or not.
        /// </summary>
        /// <param name="gameObject"></param>
        /// <typeparam name="T">The type of component.</typeparam>
        /// <returns>True if the component exists on the GameObject, otherwise false.</returns>
        public static bool HasComponent<T>(GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() != null;
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Check if a GameObject has a component or not.
        /// </summary>
        /// <param name="gameObject"></param>
        /// <typeparam name="T">The type of component.</typeparam>
        /// <returns>True if the component exists on the GameObject, otherwise false.</returns>
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return Marvelous.HasComponent<T>(gameObject);
        }
    }
}
