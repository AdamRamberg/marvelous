using System;
using System.Collections;
using UnityEngine;

namespace Marvelous
{
    public static class MonoBehaviourExtensions
    {
        public static void ClearInterval(this MonoBehaviour mb, Coroutine coroutine)
        {
            mb.StopCoroutine(coroutine);
        }

        public static Coroutine SetTimeout(this MonoBehaviour mb, Action function, float delay)
        {
            return mb.StartCoroutine(SetTimeout(function, delay));
        }

        private static IEnumerator SetTimeout(Action function, float delay)
        {
            yield return new WaitForSeconds(delay);
            function();
        }

        public static Coroutine SetInterval(this MonoBehaviour mb, Action function, float delay)
        {
            return mb.StartCoroutine(SetInterval(function, delay));
        }

        private static IEnumerator SetInterval(Action function, float delay)
        {
            while (true && function != null)
            {
                yield return new WaitForSeconds(delay);
                function();
            }
        }
    }
}
