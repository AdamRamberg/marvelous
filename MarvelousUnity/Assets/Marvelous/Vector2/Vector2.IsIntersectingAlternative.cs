using UnityEngine;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Find out if two lines intersect.
        /// </summary>
        /// <param name="line1P1">Point 1 of line 1.</param>
        /// <param name="line1P2">Point 2 of line 1.</param>
        /// <param name="line2P1">Point 1 of line 2.</param>
        /// <param name="line2P2">Point 2 of line 2.</param>
        /// <returns>True if the 2 lines are intersecting, otherwise false.</returns>
        public static bool IsIntersectingAlternative(Vector2 line1P1, Vector2 line1P2, Vector2 line2P1, Vector2 line2P2)
        {
            float denominator = (line2P2.y - line2P1.y) * (line1P2.x - line1P1.x) - (line2P2.x - line2P1.x) * (line1P2.y - line1P1.y);
            if (denominator != 0)
            {
                float u_a = ((line2P2.x - line2P1.x) * (line1P1.y - line2P1.y) - (line2P2.y - line2P1.y) * (line1P1.x - line2P1.x)) / denominator;
                float u_b = ((line1P2.x - line1P1.x) * (line1P1.y - line2P1.y) - (line1P2.y - line1P1.y) * (line1P1.x - line2P1.x)) / denominator;
                if (u_a >= 0 && u_a <= 1 && u_b >= 0 && u_b <= 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
