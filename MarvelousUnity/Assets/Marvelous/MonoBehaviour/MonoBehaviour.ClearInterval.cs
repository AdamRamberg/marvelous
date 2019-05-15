using System;
using System.Collections;
using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Cancels a timed, action which was previously established by a call to SetInterval or SetTimeout.
        /// </summary>
        /// <param name="mb">MonoBehaviour that initiated the Coroutine.</param>
        /// <param name="coroutine">The coroutine to stop.</param>
        public static void ClearInterval(MonoBehaviour mb, Coroutine coroutine)
        {
            mb.StopCoroutine(coroutine);
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Cancels a timed, action which was previously established by a call to SetInterval or SetTimeout.
        /// </summary>
        /// <param name="mb">MonoBehaviour that initiated the Coroutine.</param>
        /// <param name="coroutine">The coroutine to stop.</param>
        public static void ClearInterval(this MonoBehaviour mb, Coroutine coroutine)
        {
            Marvelous.ClearInterval(mb, coroutine);
        }
    }
}
