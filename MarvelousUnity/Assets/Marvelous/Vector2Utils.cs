using UnityEngine;

namespace Marvelous
{
    public static class Vector2Utils
    {
        // Find out if two lines intersect
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
