using System.Collections.Generic;
using UnityEngine;

namespace Marvelous
{
    public static class GameObjectExtensions
    {
        // Tries to get a component on the the GameObject. If the component doesn't exists it adds it and return the newly added component.
        public static T GetOrAddComponent<T>(this GameObject go) where T : Component
        {
            return go.GetComponent<T>() == null ? go.AddComponent<T>() : go.GetComponent<T>();
        }

        public static bool HasComponent<T>(this GameObject go) where T : Component
        {
            return go.GetComponent<T>() != null;
        }
    }
}
