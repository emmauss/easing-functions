using System;

namespace Easing
{
    //
    // All methods return a float in the range of 0 <= x <= 1.
    //
    public partial class Ease
    {
        private const float MIN = 0.0f;
        private const float MAX = 1.0f;
        private const float PI = (float)Math.PI;

        private static void ScaleParameters(ref float y, ref float deltaX, float yScale, float xScale)
        {
            y /= yScale;
            deltaX /= xScale;
        }

        private static float CoordinatesWithinRange(float newY, float x)
        {
            if (x <= MIN || newY <= MIN)
            {
                return MIN;
            }
            else if (x >= MAX || newY >= MAX)
            {
                return MAX;
            }
            else
            {
                return newY;
            }
        }

        private static float Sin(float value)
        {
            return (float)Math.Sin(value);
        }

        private static float Asin(float value)
        {
            return (float)Math.Asin(value);
        }

        private static float Sqrt(float value)
        {
            return (float)Math.Sqrt(value);
        }

        private static float Pow(float value, float exponent)
        {
            return (float)Math.Pow(Math.Abs(value), exponent);
        }
    }
}
