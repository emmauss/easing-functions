/* MIT License

Copyright (c) 2019 Mark Bromell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Easing
{
    using System;

    public abstract class Ease
    {
        public Point Origin { get; set; }
        public Point Destination { get; set; }

        protected float Min;
        protected float Max;
        protected const float PI = (float)Math.PI;

        public Ease()
        {
            Min = 0;
            Max = 1;
        }

        public Ease(Point from, Point to)
        {
            Origin = from;
            Destination = to;
        }

        public abstract float In(float x);

        public abstract float Out(float x);

        public abstract float InOut(float x);

        public abstract float InInverse(float y);

        public abstract float OutInverse(float y);

        public abstract float InOutInverse(float y);

        protected float NormailzeX(float x)
        {
            x -= Min;
            x /= Max - Min;
            return x;
        }

        protected float NormailzeY(float y)
        {
            y -= Min;
            y /= Max - Min;
            return y;
        }

        protected float DenormailzeX(float x)
        {
            x *= Max - Min;
            x += Min;
            return x;
        }

        protected float DenormailzeY(float y)
        {
            y *= Max - Min;
            y += Min;
            return y;
        }

        protected void NormailzePoint(ref Point point)
        {
            point.X -= Origin.X;
            point.Y -= Origin.Y;

            point.X /= Destination.X - Origin.X;
            point.Y /= Destination.Y - Origin.Y;
        }

        protected void DenormalizePoint(ref Point point)
        {
            point.X *= Destination.X - Origin.X;
            point.Y *= Destination.Y - Origin.Y;

            point.X += Origin.X;
            point.Y += Origin.Y;
        }

        protected static float Sin(float value)
        {
            return (float)Math.Sin(value);
        }

        protected static float Asin(float value)
        {
            return (float)Math.Asin(value);
        }

        protected static float Sqrt(float value)
        {
            return (float)Math.Sqrt(value);
        }

        protected static float Pow(float value, float exponent)
        {
            return (float)Math.Pow(Math.Abs(value), exponent);
        }
    }
}
