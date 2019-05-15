using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Instantiates and adds the prefab to the IList.
        /// </summary>
        /// <param name="list">The IList to add the prefab to.</param>
        /// <param name="prefab">The prefab.</param>
        /// <param name="position">The position of the prefab returned.</param>
        /// <param name="quaternion">The rotation of the prefab returned.</param>
        /// <typeparam name="T">The type of prefab in the IList.</typeparam>
        /// <returns>The newly instantiated prefab.</returns>
        public static T InstantiateAndAdd<T>(IList<T> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion) where T : UnityEngine.Component
        {
            var component = GameObject.Instantiate(prefab, position, quaternion) as T;
            list.Add(component);
            return component;
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Instantiates and adds the prefab to the IList.
        /// </summary>
        /// <param name="list">The IList to add the prefab to.</param>
        /// <param name="prefab">The prefab.</param>
        /// <param name="position">The position of the prefab returned.</param>
        /// <param name="quaternion">The rotation of the prefab returned.</param>
        /// <typeparam name="T">The type of prefab in the IList.</typeparam>
        /// <returns>The newly instantiated prefab.</returns>
        public static T InstantiateAndAdd<T>(this IList<T> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion) where T : UnityEngine.Component
        {
            return Marvelous.InstantiateAndAdd<T>(list, prefab, position, quaternion);
        }
    }
}
