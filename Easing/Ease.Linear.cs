namespace Easing
{
    public partial class Ease
    {
        public class Linear : IEase
        {
            public float In(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = InInverse(y) + deltaX;
                float newY = x;

                return CoordinatesWithinRange(newY, x);
            }

            public float InInverse(float y)
            {
                float x = y;
                return x;
            }

            public float Out(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = OutInverse(y) + deltaX;
                float newY = x;

                return CoordinatesWithinRange(newY, x);
            }

            public float OutInverse(float y)
            {
                float x = y;
                return x;
            }

            public float InOut(float y, float deltaX, float yScale = 1, float xScale = 1)
            {
                ScaleParameters(ref y, ref deltaX, yScale, xScale);

                float x = InOutInverse(y) + deltaX;
                float newY = x;

                return CoordinatesWithinRange(newY, x);
            }

            public float InOutInverse(float y)
            {
                float x = y;
                return x;
            }
        }
    }

}
