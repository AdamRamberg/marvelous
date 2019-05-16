using System;
using System.Collections;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// SetInterval repeatedly calls a function, with a fixed time delay between each call.
        /// </summary>
        /// <param name="mb">MonoBehaviour that is going to start the Coroutine.</param>
        /// <param name="function">A function to be executed every delay seconds. </param>
        /// <param name="delay">The time, in seconds, the timer should delay in between executions of the specified function. </param>
        /// <returns>The underlying Coroutine started.</returns>
        public static Coroutine SetInterval(MonoBehaviour mb, Action function, float delay)
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

    public static partial class Extensions
    {
        /// <summary>
        /// SetInterval repeatedly calls a function, with a fixed time delay between each call.
        /// </summary>
        /// <param name="mb">MonoBehaviour that is going to start the Coroutine.</param>
        /// <param name="function">A function to be executed every delay seconds. </param>
        /// <param name="delay">The time, in seconds, the timer should delay in between executions of the specified function. </param>
        /// <returns>The underlying Coroutine started.</returns>
        public static Coroutine SetInterval(this MonoBehaviour mb, Action function, float delay)
        {
            return Marvelous.SetInterval(mb, function, delay);
        }
    }
}
