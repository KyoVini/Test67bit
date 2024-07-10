using UnityEngine;
namespace GymBeastLike
{
    public static class EaseCalculation
    {
        public static float EaseInOut(float t)
        {
            return t < 0.5f ? 4f * t * t * t : 1f - Mathf.Pow(-2f * t + 2f, 3f) / 2f;
        }

        public static float EaseIn(float t)
        {
            return t * t;
        }

        public static float EaseOut(float t)
        {
            return 1f - (1f - t) * (1f - t);
        }
    }
}
    
