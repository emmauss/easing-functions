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
    public class Quartic : Ease
    {
        public Quartic() : base() { }

        public Quartic(Point origin, Point destination) : base(origin, destination) { }

        public override Point In(float x)
        {
            x = NormaliseInput(x);
            float y = Pow(x, 4);
            y = DenormaliseOutput(y);

            return new Point(x, y);
        }

        public override Point Out(float x)
        {
            x = NormaliseInput(x);
            float y = 1 - Pow(x - 1, 4);
            y = DenormaliseOutput(y);

            return new Point(x, y);
        }

        public override Point InOut(float x)
        {
            x = NormaliseInput(x);
            float y = 0.5f;

            if (x < 0.5)
                y = 8 * Pow(x, 4);
            else if (x > 0.5)
                y = 1 - 8 * Pow(x - 1, 4);

            y = DenormaliseOutput(y);

            return new Point(x, y);
        }

        public override Point InInverse(float y)
        {
            y = NormaliseInput(y);
            float x = Pow(y, 1.0f / 4.0f);
            x = DenormaliseOutput(x);

            return new Point(x, y);
        }

        public override Point OutInverse(float y)
        {
            y = NormaliseInput(y);
            float x = 1 - Pow(1 - y, 1.0f / 4.0f);
            x = DenormaliseOutput(x);

            return new Point(x, y);
        }

        public override Point InOutInverse(float y)
        {
            y = NormaliseInput(y);
            float x = 0.5f;

            if (y < 0.5)
                x = Pow(y / 8, 1.0f / 4.0f);
            else if (y > 0.5)
                x = 1 - Pow((1 - y) / 8, 1.0f / 4.0f);

            x = DenormaliseOutput(x);

            return new Point(x, y);
        }
    }
}
