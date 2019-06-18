namespace Easing
{
    public partial class Ease
    {
        public class Quadratic : IEase
        {
            public float In(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = InInverse(y) + deltaX;
                float newY = Pow(x, 2);

                return CoordinatesWithinRange(newY, x);
            }

            public float InInverse(float y)
            {
                float x = Sqrt(y);
                return x;
            }

            public float Out(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = OutInverse(y) + deltaX;
                float newY = 1 - Pow(x - 1, 2);

                return CoordinatesWithinRange(newY, x);
            }

            public float OutInverse(float y)
            {
                float x = 1 - Sqrt(1 - y);
                return x;
            }

            public float InOut(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = InOutInverse(y) + deltaX;
                float newY;

                if (x < 0.5)
                {
                    newY = 2 * Pow(x, 2);
                }
                else if (x > 0.5)
                {
                    newY = 1 - 2 * Pow(x - 1, 2);
                }
                else
                {
                    newY = 0.5f;
                }

                return CoordinatesWithinRange(newY, x);
            }

            public float InOutInverse(float y)
            {
                float x;

                if (y < 0.5)
                {
                    x = Sqrt(y / 2);
                }
                else if (y > 0.5)
                {
                    x = 1 - Sqrt(-(y - 1) / 2);
                }
                else
                {
                    x = 0.5f;
                }

                return x;
            }
        }
    }
}
