using System;

namespace Marvelous
{
    // Create an Action delegates that takes 5 parameters. Not included in the standard lib.
    public delegate void Action<T1, T2, T3, T4, T5>(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);
}
