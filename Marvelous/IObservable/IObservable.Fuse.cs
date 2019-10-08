using System;
using System.Collections.Generic;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Fuses two observables into one. It uses resultSelector to create what is returned on every OnNext.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="resultSelector">Used to fused and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="M">Type of the new fused IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> Fuse<T1, T2, M>(
            IObservable<T1> source1, IObservable<T2> source2,
            Func<T1, T2, M> resultSelector = null,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            return new Fuse<T1, T2, M>(source1, source2, resultSelector, initialValue1, initialValue2);
        }

        /// <summary>
        /// Fuses two observables into one. The resulting Observable will combine all sources using ValueTuples.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <returns>A new IObservable of type ValueTuple<T1, T2> combining the IObservables sent in.</returns>
        public static IObservable<ValueTuple<T1, T2>> Fuse<T1, T2>(
            IObservable<T1> source1, IObservable<T2> source2,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            return new Fuse<T1, T2, ValueTuple<T1, T2>>(source1, source2, (t1, t2) => new ValueTuple<T1, T2>(t1, t2), initialValue1, initialValue2);
        }

        /// <summary>
        /// Fuses three observables into one. It uses resultSelector to create what is returned on every OnNext.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="resultSelector">Used to fuse and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="M">Type of the new fused IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> Fuse<T1, T2, T3, M>(
            IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3,
            Func<T1, T2, T3, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            return new Fuse<T1, T2, T3, M>(source1, source2, source3, resultSelector, initialValue1, initialValue2, initialValue3);
        }

        /// <summary>
        /// Fuses three observables into one. The resulting Observable will combine all sources using ValueTuples.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <returns>A new IObservable of type ValueTuple<T1, T2, T3> combining the IObservables sent in.</returns>
        public static IObservable<ValueTuple<T1, T2, T3>> Fuse<T1, T2, T3>(
            IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            return new Fuse<T1, T2, T3, ValueTuple<T1, T2, T3>>(source1, source2, source3, (t1, t2, t3) => new ValueTuple<T1, T2, T3>(t1, t2, t3), initialValue1, initialValue2, initialValue3);
        }

        /// <summary>
        /// Fuses four observables into one. It uses resultSelector to create what is returned on every OnNext.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="source4">IObservable to be fused.</param>
        /// <param name="resultSelector">Used to merg and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="M">Type of the new fused IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> Fuse<T1, T2, T3, T4, M>(
            IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4,
            Func<T1, T2, T3, T4, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            return new Fuse<T1, T2, T3, T4, M>(source1, source2, source3, source4, resultSelector, initialValue1, initialValue2, initialValue3, initialValue4);
        }

        /// <summary>
        /// Fuses four observables into one. The resulting Observable will combine all sources using ValueTuples.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="source4">IObservable to be fused.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable3.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the third IObservable.</typeparam>
        /// <returns>A new IObservable of type ValueTuple<T1, T2, T3, T4> combining the IObservables sent in.</returns>
        public static IObservable<ValueTuple<T1, T2, T3, T4>> Fuse<T1, T2, T3, T4>(
            IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            return new Fuse<T1, T2, T3, T4, ValueTuple<T1, T2, T3, T4>>(source1, source2, source3, source4, (t1, t2, t3, t4) => new ValueTuple<T1, T2, T3, T4>(t1, t2, t3, t4), initialValue1, initialValue2, initialValue3, initialValue4);
        }

        /// <summary>
        /// Fuses five observables into one. It uses resultSelector to create what is returned on every OnNext.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="source4">IObservable to be fused.</param>
        /// <param name="source5">IObservable to be fused.</param>
        /// <param name="resultSelector">Used to fuses and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <param name="initialValue5">Initial value of observerable5.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="T5">The type of the fifth IObservable.</typeparam>
        /// <typeparam name="M">Type of the new fused IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> Fuse<T1, T2, T3, T4, T5, M>(
            IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5,
            Func<T1, T2, T3, T4, T5, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            return new Fuse<T1, T2, T3, T4, T5, M>(source1, source2, source3, source4, source5, resultSelector, initialValue1, initialValue2, initialValue3, initialValue4, initialValue5);
        }

        /// <summary>
        /// Fuses five observables into one. The resulting Observable will combine all sources using ValueTuples.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="source4">IObservable to be fused.</param>
        /// <param name="source5">IObservable to be fused.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <param name="initialValue5">Initial value of observerable5.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="T5">The type of the fifth IObservable.</typeparam>
        /// <returns>A new IObservable of type ValueTuple<T1, T2, T3, T4, T5> combining the IObservables sent in.</returns>
        public static IObservable<ValueTuple<T1, T2, T3, T4, T5>> Fuse<T1, T2, T3, T4, T5>(
            IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            return new Fuse<T1, T2, T3, T4, T5, ValueTuple<T1, T2, T3, T4, T5>>(source1, source2, source3, source4, source5, (t1, t2, t3, t4, t5) => new ValueTuple<T1, T2, T3, T4, T5>(t1, t2, t3, t4, t5), initialValue1, initialValue2, initialValue3, initialValue4, initialValue5);
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Fuses 2 observables into one. It uses resultSelector to create what is returned on every OnNext.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="resultSelector">Used to fuses and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="M">Type of the new fused IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> Fuse<T1, T2, M>(
            this IObservable<T1> source1, IObservable<T2> source2,
            Func<T1, T2, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            return Marvelous.Fuse<T1, T2, M>(source1, source2, resultSelector, initialValue1, initialValue2);
        }

        /// <summary>
        /// Fuses two observables into one. The resulting Observable will combine all sources using ValueTuples.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <returns>A new IObservable of type ValueTuple<T1, T2> combining the IObservables sent in.</returns>
        public static IObservable<ValueTuple<T1, T2>> Fuse<T1, T2>(
            this IObservable<T1> source1, IObservable<T2> source2,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            return Marvelous.Fuse<T1, T2>(source1, source2, initialValue1, initialValue2);
        }

        /// <summary>
        /// Fuses three observables into one. It uses resultSelector to create what is returned on every OnNext.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="resultSelector">Used to fused and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="M">Type of the new fused IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> Fuse<T1, T2, T3, M>(
            this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3,
            Func<T1, T2, T3, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            return Marvelous.Fuse<T1, T2, T3, M>(source1, source2, source3, resultSelector, initialValue1, initialValue2, initialValue3);
        }

        /// <summary>
        /// Fuses three observables into one. The resulting Observable will combine all sources using ValueTuples.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <returns>A new IObservable of type ValueTuple<T1, T2, T3> combining the IObservables sent in.</returns>
        public static IObservable<ValueTuple<T1, T2, T3>> Fuse<T1, T2, T3>(
            this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            return Marvelous.Fuse<T1, T2, T3>(source1, source2, source3, initialValue1, initialValue2, initialValue3);
        }

        /// <summary>
        /// Fuses four observables into one. It uses resultSelector to create what is returned on every OnNext.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="source4">IObservable to be fused.</param>
        /// <param name="resultSelector">Used to fuses and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="M">Type of the new fused IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> Fuse<T1, T2, T3, T4, M>(
            this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4,
            Func<T1, T2, T3, T4, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            return Marvelous.Fuse<T1, T2, T3, T4, M>(source1, source2, source3, source4, resultSelector, initialValue1, initialValue2, initialValue3, initialValue4);
        }

        /// <summary>
        /// Fuses four observables into one. The resulting Observable will combine all sources using ValueTuples.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="source4">IObservable to be fused.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable3.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the third IObservable.</typeparam>
        /// <returns>A new IObservable of type ValueTuple<T1, T2, T3, T4> combining the IObservables sent in.</returns>
        public static IObservable<ValueTuple<T1, T2, T3, T4>> Fuse<T1, T2, T3, T4>(
            this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            return Marvelous.Fuse<T1, T2, T3, T4>(source1, source2, source3, source4, initialValue1, initialValue2, initialValue3, initialValue4);
        }

        /// <summary>
        /// Fuses five observables into one. It uses resultSelector to create what is returned on every OnNext.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="source4">IObservable to be fused.</param>
        /// <param name="source5">IObservable to be fused.</param>
        /// <param name="resultSelector">Used to fuses and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <param name="initialValue5">Initial value of observerable5.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="T5">The type of the fifth IObservable.</typeparam>
        /// <typeparam name="M">Type of the new fused IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> Fuse<T1, T2, T3, T4, T5, M>(
            this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5,
            Func<T1, T2, T3, T4, T5, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            return Marvelous.Fuse<T1, T2, T3, T4, T5, M>(source1, source2, source3, source4, source5, resultSelector, initialValue1, initialValue2, initialValue3, initialValue4, initialValue5);
        }

        /// <summary>
        /// Fuses five observables into one. The resulting Observable will combine all sources using ValueTuples.
        /// </summary>
        /// <param name="source1">IObservable to be fused.</param>
        /// <param name="source2">IObservable to be fused.</param>
        /// <param name="source3">IObservable to be fused.</param>
        /// <param name="source4">IObservable to be fused.</param>
        /// <param name="source5">IObservable to be fused.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <param name="initialValue5">Initial value of observerable5.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="T5">The type of the fifth IObservable.</typeparam>
        /// <returns>A new IObservable of type ValueTuple<T1, T2, T3, T4, T5> combining the IObservables sent in.</returns>
        public static IObservable<ValueTuple<T1, T2, T3, T4, T5>> Fuse<T1, T2, T3, T4, T5>(
            this IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            return Marvelous.Fuse<T1, T2, T3, T4, T5>(source1, source2, source3, source4, source5, initialValue1, initialValue2, initialValue3, initialValue4, initialValue5);
        }
    }

    internal class Fuse<T1, T2, M> : BaseObservable<M>, IObservable<M>
    {
        ProxyObserver<T1> _observer1;
        IDisposable _unsubscriber1;

        ProxyObserver<T2> _observer2;
        IDisposable _unsubscriber2;

        protected override bool IsCompleted { get { return _observer1.Completed && _observer2.Completed; } }

        public Fuse(IObservable<T1> source1, IObservable<T2> source2,
            Func<T1, T2, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            _observer1 = new ProxyObserver<T1>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t1) => _observers.ForEach((o, _t1, _o2) => o.OnNext(resultSelector(_t1, _o2 != null ? _o2.LastValue : default(T2))), t1, _observer2),
                initialValue: initialValue1
            );

            _observer2 = new ProxyObserver<T2>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t2) => _observers.ForEach((o, _t2, _o1) => o.OnNext(resultSelector(_o1 != null ? _o1.LastValue : default(T1), _t2)), t2, _observer1),
                initialValue: initialValue2
            );

            _unsubscriber1 = source1.Subscribe(_observer1);
            _unsubscriber2 = source2.Subscribe(_observer2);
        }

        ~Fuse()
        {
            _unsubscriber1.Dispose();
            _unsubscriber2.Dispose();
        }
    }

    internal class Fuse<T1, T2, T3, M> : BaseObservable<M>, IObservable<M>
    {
        ProxyObserver<T1> _observer1;
        IDisposable _unsubscriber1;

        ProxyObserver<T2> _observer2;
        IDisposable _unsubscriber2;

        ProxyObserver<T3> _observer3;
        IDisposable _unsubscriber3;

        protected override bool IsCompleted { get { return _observer1.Completed && _observer2.Completed && _observer3.Completed; } }

        public Fuse(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3,
            Func<T1, T2, T3, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            _observer1 = new ProxyObserver<T1>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t1) => _observers.ForEach((o, _t1, _o2, _o3) => o.OnNext(resultSelector(_t1, _o2 != null ? _o2.LastValue : default(T2), _o3 != null ? _o3.LastValue : default(T3))), t1, _observer2, _observer3),
                initialValue: initialValue1
            );

            _observer2 = new ProxyObserver<T2>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t2) => _observers.ForEach((o, _o1, _t2, _o3) => o.OnNext(resultSelector(_o1 != null ? _o1.LastValue : default(T1), _t2, _o3 != null ? _o3.LastValue : default(T3))), _observer1, t2, _observer3),
                initialValue: initialValue2
            );

            _observer3 = new ProxyObserver<T3>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t3) => _observers.ForEach((o, _o1, _o2, _t3) => o.OnNext(resultSelector(_o1 != null ? _o1.LastValue : default(T1), _o2 != null ? _o2.LastValue : default(T2), _t3)), _observer1, _observer2, t3),
                initialValue: initialValue3
            );

            _unsubscriber1 = source1.Subscribe(_observer1);
            _unsubscriber2 = source2.Subscribe(_observer2);
            _unsubscriber3 = source3.Subscribe(_observer3);
        }

        ~Fuse()
        {
            _unsubscriber1.Dispose();
            _unsubscriber2.Dispose();
            _unsubscriber3.Dispose();
        }
    }

    internal class Fuse<T1, T2, T3, T4, M> : BaseObservable<M>, IObservable<M>
    {
        ProxyObserver<T1> _observer1;
        IDisposable _unsubscriber1;

        ProxyObserver<T2> _observer2;
        IDisposable _unsubscriber2;

        ProxyObserver<T3> _observer3;
        IDisposable _unsubscriber3;

        ProxyObserver<T4> _observer4;
        IDisposable _unsubscriber4;

        protected override bool IsCompleted { get { return _observer1.Completed && _observer2.Completed && _observer3.Completed && _observer4.Completed; } }

        public Fuse(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4,
            Func<T1, T2, T3, T4, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            _observer1 = new ProxyObserver<T1>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t1) => _observers.ForEach((o, _t1, _o2, _o3, _o4) =>
                {
                    o.OnNext(resultSelector(
                        _t1,
                        _o2 != null ? _o2.LastValue : default(T2),
                        _o3 != null ? _o3.LastValue : default(T3),
                        _o4 != null ? _o4.LastValue : default(T4)
                    ));
                }, t1, _observer2, _observer3, _observer4),
                initialValue: initialValue1
            );

            _observer2 = new ProxyObserver<T2>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t2) => _observers.ForEach((o, _o1, _t2, _o3, _o4) =>
                {
                    o.OnNext(resultSelector(
                        _o1 != null ? _o1.LastValue : default(T1),
                        _t2,
                        _o3 != null ? _o3.LastValue : default(T3),
                        _o4 != null ? _o4.LastValue : default(T4)
                    ));
                }, _observer1, t2, _observer3, _observer4),
                initialValue: initialValue2
            );

            _observer3 = new ProxyObserver<T3>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t3) => _observers.ForEach((o, _o1, _o2, _t3, _o4) =>
                {
                    o.OnNext(resultSelector(
                        _o1 != null ? _o1.LastValue : default(T1),
                        _o2 != null ? _o2.LastValue : default(T2),
                        _t3,
                        _o4 != null ? _o4.LastValue : default(T4)
                    ));
                }, _observer1, _observer2, t3, _observer4),
                initialValue: initialValue3
            );

            _observer4 = new ProxyObserver<T4>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t4) => _observers.ForEach((o, _o1, _o2, _o3, _t4) =>
                {
                    o.OnNext(resultSelector(
                        _o1 != null ? _o1.LastValue : default(T1),
                        _o2 != null ? _o2.LastValue : default(T2),
                        _o3 != null ? _o3.LastValue : default(T3),
                        _t4
                    ));
                }, _observer1, _observer2, _observer3, t4),
                initialValue: initialValue4
            );

            _unsubscriber1 = source1.Subscribe(_observer1);
            _unsubscriber2 = source2.Subscribe(_observer2);
            _unsubscriber3 = source3.Subscribe(_observer3);
            _unsubscriber4 = source4.Subscribe(_observer4);
        }

        ~Fuse()
        {
            _unsubscriber1.Dispose();
            _unsubscriber2.Dispose();
            _unsubscriber3.Dispose();
            _unsubscriber4.Dispose();
        }
    }

    internal class Fuse<T1, T2, T3, T4, T5, M> : BaseObservable<M>, IObservable<M>
    {
        ProxyObserver<T1> _observer1;
        IDisposable _unsubscriber1;

        ProxyObserver<T2> _observer2;
        IDisposable _unsubscriber2;

        ProxyObserver<T3> _observer3;
        IDisposable _unsubscriber3;

        ProxyObserver<T4> _observer4;
        IDisposable _unsubscriber4;

        ProxyObserver<T5> _observer5;
        IDisposable _unsubscriber5;

        protected override bool IsCompleted { get { return _observer1.Completed && _observer2.Completed && _observer3.Completed && _observer4.Completed && _observer5.Completed; } }

        public Fuse(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5,
            Func<T1, T2, T3, T4, T5, M> resultSelector,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            _observer1 = new ProxyObserver<T1>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t1) => _observers.ForEach((o, _t1, _o2, _o3, _o4, _o5) =>
                {
                    o.OnNext(resultSelector(
                        _t1,
                        _o2 != null ? _o2.LastValue : default(T2),
                        _o3 != null ? _o3.LastValue : default(T3),
                        _o4 != null ? _o4.LastValue : default(T4),
                        _o5 != null ? _o5.LastValue : default(T5)
                    ));
                }, t1, _observer2, _observer3, _observer4, _observer5),
                initialValue: initialValue1
            );

            _observer2 = new ProxyObserver<T2>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t2) => _observers.ForEach((o, _o1, _t2, _o3, _o4, _o5) =>
                {
                    o.OnNext(resultSelector(
                        _o1 != null ? _o1.LastValue : default(T1),
                        _t2,
                        _o3 != null ? _o3.LastValue : default(T3),
                        _o4 != null ? _o4.LastValue : default(T4),
                        _o5 != null ? _o5.LastValue : default(T5)
                    ));
                }, _observer1, t2, _observer3, _observer4, _observer5),
                initialValue: initialValue2
            );

            _observer3 = new ProxyObserver<T3>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t3) => _observers.ForEach((o, _o1, _o2, _t3, _o4, _o5) =>
                {
                    o.OnNext(resultSelector(
                        _o1 != null ? _o1.LastValue : default(T1),
                        _o2 != null ? _o2.LastValue : default(T2),
                        _t3,
                        _o4 != null ? _o4.LastValue : default(T4),
                        _o5 != null ? _o5.LastValue : default(T5)
                    ));
                }, _observer1, _observer2, t3, _observer4, _observer5),
                initialValue: initialValue3
            );

            _observer4 = new ProxyObserver<T4>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t4) => _observers.ForEach((o, _o1, _o2, _o3, _t4, _o5) =>
                {
                    o.OnNext(resultSelector(
                        _o1 != null ? _o1.LastValue : default(T1),
                        _o2 != null ? _o2.LastValue : default(T2),
                        _o3 != null ? _o3.LastValue : default(T3),
                        _t4,
                        _o5 != null ? _o5.LastValue : default(T5)
                    ));
                }, _observer1, _observer2, _observer3, t4, _observer5),
                initialValue: initialValue4
            );

            _observer5 = new ProxyObserver<T5>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t5) => _observers.ForEach((o, _o1, _o2, _o3, _o4, _t5) =>
                {
                    o.OnNext(resultSelector(
                        _o1 != null ? _o1.LastValue : default(T1),
                        _o2 != null ? _o2.LastValue : default(T2),
                        _o3 != null ? _o3.LastValue : default(T3),
                        _o4 != null ? _o4.LastValue : default(T4),
                        _t5
                    ));
                }, _observer1, _observer2, _observer3, _observer4, t5),
                initialValue: initialValue5
            );

            _unsubscriber1 = source1.Subscribe(_observer1);
            _unsubscriber2 = source2.Subscribe(_observer2);
            _unsubscriber3 = source3.Subscribe(_observer3);
            _unsubscriber4 = source4.Subscribe(_observer4);
            _unsubscriber5 = source5.Subscribe(_observer5);
        }

        ~Fuse()
        {
            _unsubscriber1.Dispose();
            _unsubscriber2.Dispose();
            _unsubscriber3.Dispose();
            _unsubscriber4.Dispose();
            _unsubscriber5.Dispose();
        }
    }

    internal class ProxyObserver<T> : IObserver<T>
    {
        public T LastValue;
        public bool Completed = false;

        private Action _onCompleted;
        public Action<Exception> _onError;
        public Action<T> _onNext;

        public ProxyObserver(Action onCompleted, Action<Exception> onError, Action<T> onNext, T initialValue)
        {
            this._onCompleted = onCompleted;
            this._onError = onError;
            this._onNext = onNext;
            LastValue = initialValue;
        }

        public void OnCompleted()
        {
            Completed = true;
            _onCompleted();
        }

        public void OnError(Exception error)
        {
            _onError(error);
        }

        public void OnNext(T value)
        {
            LastValue = value;
            _onNext(value);
        }
    }

    internal abstract class BaseObservable<T> : IObservable<T>
    {
        protected List<IObserver<T>> _observers = new List<IObserver<T>>();

        protected abstract bool IsCompleted { get; }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new ObservableUnsubscriber<T>(_observers, observer);
        }

        protected void OnCompleted()
        {
            if (IsCompleted)
            {
                for (int i = 0; _observers != null && i < _observers.Count; ++i)
                {
                    _observers[i].OnCompleted();
                }
            }
        }

        protected void OnError(Exception e)
        {
            for (int i = 0; _observers != null && i < _observers.Count; ++i)
            {
                _observers[i].OnError(e);
            }
        }
    }

    internal class ObservableUnsubscriber<T> : IDisposable
    {
        private List<IObserver<T>> _observers;
        private IObserver<T> _observer;

        public ObservableUnsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }

}

