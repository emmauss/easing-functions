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
        public override float In(float x)
        {
            x = NormailzeX(x);
            float y = 1 + Sin((PI / 2) * x - (PI / 2));
            return NormailzeY(y);
        }

        public override float Out(float x)
        {
            x = NormailzeX(x);
            float y = Sin((PI / 2) * x);
            return NormailzeY(y);
        }

        public override float InOut(float x)
        {
            x = NormailzeX(x);
            float y = 0.5f + 0.5f * Sin((PI * x) - (PI / 2));
            return NormailzeY(y);
        }

        public override float InInverse(float y)
        {
            y = NormailzeY(y);
            float x = (2 * Asin(y - 1) + PI) / PI;
            return NormailzeX(x);
        }

        public override float OutInverse(float y)
        {
            y = NormailzeY(y);
            float x = (2 * Asin(y)) / PI;
            return NormailzeX(x);
        }

        public override float InOutInverse(float y)
        {
            y = NormailzeY(y);
            float x = (2 * Asin((2 * y) - 1) + PI) / (2 * PI);
            return NormailzeX(x);
        }
    }
}

