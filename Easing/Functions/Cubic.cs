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
    public class Cubic : Ease
    {
        public Cubic() : base() { }

        public Cubic(Vector scale) : base(scale) { }

        public override float In(float x)
        {
            float normalisedX = NormaliseInput(x, Scale.X);
            float y = Scale.Y * Pow(normalisedX, 3);
            
            return OutputInRange(x, y);
        }

        public override float Out(float x)
        {
            float normalisedX = NormaliseInput(x, Scale.X);
            float y = Scale.Y + Scale.Y * Pow(normalisedX - 1, 3);
            
            return OutputInRange(x, y);
        }

        public override float InOut(float x)
        {
            float normalisedX = NormaliseInput(x, Scale.X);
            float center = Scale.X / 2;
            float y = Scale.Y / 2;

            if (x < center)
            {
                y = 4 * Scale.Y * Pow(normalisedX, 3);
            }
            else if (x > center)
            {
                y = Scale.Y + 4 * Scale.Y * Pow(normalisedX - 1, 3);
            }

            
            return OutputInRange(x, y);
        }

        public override float InInverse(float y)
        {
            float normalisedY = NormaliseInput(y, Scale.Y);
            float x = Scale.X * Pow(normalisedY, 1.0f / 3.0f);
            
            return InverseOutputInRange(x, y);
        }

        public override float OutInverse(float y)
        {
            float normalisedY = NormaliseInput(y, Scale.Y);
            float x = Scale.X - Scale.X * Pow(1 - normalisedY, 1.0f / 3.0f);
            
            return InverseOutputInRange(x, y);
        }

        public override float InOutInverse(float y)
        {
            float normalisedY = NormaliseInput(y, Scale.Y);
            float center = Scale.Y / 2;
            float x = Scale.X / 2;

            if (y < center)
            {
                x = Scale.X * Pow(normalisedY / 4, 1.0f / 3.0f);
            }
            else if (y > center)
            {
                x = Scale.X - Scale.X * Pow((1 - normalisedY) / 4.0f, 1.0f / 3.0f);
            }

            
            return InverseOutputInRange(x, y);
        }
    }
}
