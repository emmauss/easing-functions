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

        protected const float PI = (float)Math.PI;

        public Ease()
        {
            Origin = Point.Zero;
            Destination = new Point(1, 1);
        }

        public Ease(Point origin, Point destination)
        {
            Origin = origin;
            Destination = destination;
        }

        public abstract Point In(float x);

        public abstract Point Out(float x);

        public abstract Point InOut(float x);

        public abstract Point InInverse(float y);

        public abstract Point OutInverse(float y);

        public abstract Point InOutInverse(float y);

        protected float ScaleX(float x)
        {
            return x / (Origin.Y - Destination.Y);
        }

        protected float ScaleY(float y)
        {
            return y * (Origin.X - Destination.X);
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
