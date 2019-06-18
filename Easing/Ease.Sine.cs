namespace Easing
{
    public partial class Ease
    {
        public class Sine : IEase
        {
            public float In(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = InInverse(y) + deltaX;
                float newY = 1 + Sin((PI / 2) * x - (PI / 2));

                return CoordinatesWithinRange(newY, x);
            }

            public float InInverse(float y)
            {
                float x = (2 * Asin(y - 1) + PI) / PI;
                return x;
            }

            public float Out(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = OutInverse(y) + deltaX;
                float newY = Sin((PI / 2) * x);

                return CoordinatesWithinRange(newY, x);
            }

            public float OutInverse(float y)
            {
                float x = (2 * Asin(y)) / PI;
                return x;
            }

            public float InOut(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = InOutInverse(y) + deltaX;
                float newY = 0.5f + 0.5f * Sin((PI * x) - (PI / 2));

                return CoordinatesWithinRange(newY, x);
            }

            public float InOutInverse(float y)
            {
                float x = (2 * Asin((2 * y) - 1) + PI) / (2 * PI);
                return x;
            }
        }
    }
}
