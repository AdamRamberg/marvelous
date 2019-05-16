using System;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Tries to get a component on the the GameObject. If the component doesn't exists it adds it and return the newly added component.
        /// </summary>
        /// <param name="gameObject">The GameObject.</param>
        /// <typeparam name="T">The type of component.</typeparam>
        /// <returns>The existing or newly created component.</returns>
        public static T GetOrAddComponent<T>(GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() == null ? gameObject.AddComponent<T>() : gameObject.GetComponent<T>();
        }
    }
    public static partial class Extensions
    {
        /// <summary>
        /// Tries to get a component on the the GameObject. If the component doesn't exists it adds it and return the newly added component.
        /// </summary>
        /// <param name="gameObject">The GameObject.</param>
        /// <typeparam name="T">The type of component.</typeparam>
        /// <returns>The existing or newly created component.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            return Marvelous.GetOrAddComponent<T>(gameObject);
        }
    }
}
