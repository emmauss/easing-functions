namespace Easing
{
    public interface IEase
    {
        float In(float y, float deltaX, float yScale = 1, float xScale = 1);
        float InInverse(float y);
        float InOut(float y, float deltaX, float yScale = 1, float xScale = 1);
        float InOutInverse(float y);
        float Out(float y, float deltaX, float yScale = 1, float xScale = 1);
        float OutInverse(float y);
    }
}