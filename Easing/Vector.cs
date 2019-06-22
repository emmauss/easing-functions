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
    using System.Drawing;

    public struct Vector : IEquatable<Vector>
    {
        public static Vector Zero { get => new Vector(0, 0); }
        public float X { get; set; }
        public float Y { get; set; }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator -(Vector lhs, Vector rhs)
        {
            float newX = lhs.X - rhs.X;
            float newY = lhs.Y - rhs.Y;
            return new Vector(newX, newY);
        }

        public static Vector operator +(Vector lhs, Vector rhs)
        {
            float newX = lhs.X + rhs.X;
            float newY = lhs.Y + rhs.Y;
            return new Vector(newX, newY);
        }

        public static Vector operator *(Vector lhs, float rhs)
        {
            float newX = lhs.X * rhs;
            float newY = lhs.Y * rhs;
            return new Vector(newX, newY);
        }

        public static Vector operator /(Vector lhs, float rhs)
        {
            float newX = lhs.X / rhs;
            float newY = lhs.Y / rhs;
            return new Vector(newX, newY);
        }

        public static bool operator ==(Vector lhs, Vector rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Vector lhs, Vector rhs)
        {
            return !(lhs == rhs);
        }

        public static implicit operator Vector(System.Drawing.Point rhs)
        {
            return new Vector(rhs.X, rhs.Y);
        }

        public static implicit operator System.Drawing.Point(Vector rhs)
        {
            return new Vector(rhs.X, rhs.Y);
        }

        public override bool Equals(object obj)
        {
            if (GetType() != obj.GetType()) return false;
            return Equals((Vector)obj);
        }

        public bool Equals(Vector point)
        {
            if (ReferenceEquals(this, point)) return true;
            return (X == point.X) && (Y == point.Y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (int)(X * 1000);
                hash = (hash * HashingMultiplier) ^ (int)(Y * 1000);
                return hash;
            }
        }
    }
}
