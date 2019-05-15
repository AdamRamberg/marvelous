using System;
using System.Collections;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Sets a timer which executes a function once the timer expires. This mimics javascript's API for timers and is utilizing Unity's Coroutine API to do so.
        /// </summary>
        /// <param name="mb">MonoBehaviour that is going to start the Coroutine.</param>
        /// <param name="function">A function to be executed after the timer expires.</param>
        /// <param name="delay">The time, in seconds, the timer should wait before the specified function is executed. </param>
        /// <returns>The underlying Coroutine started.</returns>
        public static Coroutine SetTimeout(MonoBehaviour mb, Action function, float delay)
        {
            return mb.StartCoroutine(SetTimeout(function, delay));
        }

        private static IEnumerator SetTimeout(Action function, float delay)
        {
            yield return new WaitForSeconds(delay);
            function();
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Sets a timer which executes a function once the timer expires. This mimics javascript's API for timers and is utilizing Unity's Coroutine API to do so.
        /// </summary>
        /// <param name="mb">MonoBehaviour that is going to start the Coroutine.</param>
        /// <param name="function">A function to be executed after the timer expires.</param>
        /// <param name="delay">The time, in seconds, the timer should wait before the specified function is executed. </param>
        /// <returns>The underlying Coroutine started.</returns>
        public static Coroutine SetTimeout(this MonoBehaviour mb, Action function, float delay)
        {
            return Marvelous.SetTimeout(mb, function, delay);
        }
    }
}
