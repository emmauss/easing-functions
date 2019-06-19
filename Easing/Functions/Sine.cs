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
    public class Sine : Ease
    {
        public override Point In(float x)
        {
            x = ScaleX(x);
            float y = 1 + Sin((PI / 2) * x - (PI / 2));
            y = ScaleY(y);

            return new Point(x, y);
        }

        public override Point Out(float x)
        {
            x = ScaleX(x);
            float y = Sin((PI / 2) * x);
            y = ScaleY(y);

            return new Point(x, y);
        }

        public override Point InOut(float x)
        {
            x = ScaleX(x);
            float y = 0.5f + 0.5f * Sin((PI * x) - (PI / 2));
            y = ScaleY(y);

            return new Point(x, y);
        }

        public override Point InInverse(float y)
        {
            y = ScaleX(y);
            float x = (2 * Asin(y - 1) + PI) / PI;
            x = ScaleY(x);

            return new Point(x, y);
        }

        public override Point OutInverse(float y)
        {
            y = ScaleX(y);
            float x = (2 * Asin(y)) / PI;
            x = ScaleY(x);

            return new Point(x, y);
        }

        public override Point InOutInverse(float y)
        {
            y = ScaleX(y);
            float x = (2 * Asin((2 * y) - 1) + PI) / (2 * PI);
            x = ScaleY(x);

            return new Point(x, y);
        }
    }
}

