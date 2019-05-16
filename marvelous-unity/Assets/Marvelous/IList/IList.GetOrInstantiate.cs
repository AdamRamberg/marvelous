using System;
using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Get or instantiate a prefab from IList based on the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to get the prefab from.</param>
        /// <param name="prefab">The prefab.</param>
        /// <param name="position">The position of the prefab returned.</param>
        /// <param name="quaternion">The rotation of the prefab returned.</param>
        /// <param name="condition">The condition to pass in order to get an already instantiated prefab from the IList.</param>
        /// <typeparam name="T">The type of prefab in the IList.</typeparam>
        /// <returns>The first prefab in the IList that satisfies the condition. If none found it returns a newly created prefab of type T.</returns>
        public static T GetOrInstantiate<T>(IList<T> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion, Func<T, bool> condition) where T : UnityEngine.Component
        {
            var component = list.First(condition);

            if (component != null)
            {
                component.transform.position = position;
                component.transform.rotation = quaternion;
                return component;
            }

            var newComponent = GameObject.Instantiate(prefab, position, quaternion) as T;
            list.Add(newComponent);
            return newComponent;
        }

        /// <summary>
        /// Get or instantiate a prefab from IList based on the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to get the prefab from.</param>
        /// <param name="prefab">The prefab.</param>
        /// <param name="position">The position of the prefab returned.</param>
        /// <param name="quaternion">The rotation of the prefab returned.</param>
        /// <param name="condition">The condition to pass in order to get an already instantiated prefab from the IList.</param>
        /// <returns>The first prefab in the IList that satisfies the condition. If none found it returns a newly created prefab.</returns>
        public static GameObject GetOrInstantiate(IList<GameObject> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion, Func<GameObject, bool> condition)
        {
            var component = list.First(condition);

            if (component != null)
            {
                component.transform.position = position;
                component.transform.rotation = quaternion;
                return component;
            }

            var newGameObject = GameObject.Instantiate(prefab, position, quaternion) as GameObject;
            list.Add(newGameObject);
            return newGameObject;
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Get or instantiate a prefab from IList based on the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to get the prefab from.</param>
        /// <param name="prefab">The prefab.</param>
        /// <param name="position">The position of the prefab returned.</param>
        /// <param name="quaternion">The rotation of the prefab returned.</param>
        /// <param name="condition">The condition to pass in order to get an already instantiated prefab from the IList.</param>
        /// <typeparam name="T">The type of prefab in the IList.</typeparam>
        /// <returns>The first prefab in the IList that satisfies the condition. If none found it returns a newly created prefab of type T.</returns>
        public static T GetOrInstantiate<T>(this IList<T> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion, Func<T, bool> condition) where T : UnityEngine.Component
        {
            return Marvelous.GetOrInstantiate<T>(list, prefab, position, quaternion, condition);
        }

        /// <summary>
        /// Get or instantiate a prefab from IList based on the test implemented by the provided Func.
        /// </summary>
        /// <param name="list">The IList to get the prefab from.</param>
        /// <param name="prefab">The prefab.</param>
        /// <param name="position">The position of the prefab returned.</param>
        /// <param name="quaternion">The rotation of the prefab returned.</param>
        /// <param name="condition">The condition to pass in order to get an already instantiated prefab from the IList.</param>
        /// <returns>The first prefab in the IList that satisfies the condition. If none found it returns a newly created prefab.</returns>
        public static GameObject GetOrInstantiate(this IList<GameObject> list, UnityEngine.Object prefab, Vector3 position, Quaternion quaternion, Func<GameObject, bool> condition)
        {
            return Marvelous.GetOrInstantiate(list, prefab, position, quaternion, condition);
        }
    }
}
