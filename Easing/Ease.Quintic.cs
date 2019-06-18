namespace Easing
{
    public partial class Ease
    {
        public class Quintic : IEase
        {
            public float In(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = InInverse(y) + deltaX;
                float newY = Pow(x, 5);

                return CoordinatesWithinRange(newY, x);
            }

            public float InInverse(float y)
            {
                float x = Pow(y, 1.0f / 5.0f);
                return x;
            }

            public float Out(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = OutInverse(y) + deltaX;
                float newY = 1 - Pow(x - 1, 5);

                return CoordinatesWithinRange(newY, x);
            }

            public float OutInverse(float y)
            {
                float x = 1 - Pow(y - 1, 1.0f / 5.0f);
                return x;
            }

            public float InOut(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = InOutInverse(y) + deltaX;
                float newY;

                if (x < 0.5)
                {
                    newY = 16 * Pow(x, 5);
                }
                else if (x > 0.5)
                {
                    newY = 1 - 16 * Pow(x - 1, 5);
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
                    x = Pow(y / 16, 1.0f / 5.0f);
                }
                else if (y > 0.5)
                {
                    x = 1 - Pow((y - 1) / 16, 1.0f / 5.0f);
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
