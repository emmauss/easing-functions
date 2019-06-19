namespace Easing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public struct Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Point operator -(Point lhs, Point rhs)
        {
            float newX = lhs.X - rhs.X;
            float newY = lhs.Y - rhs.Y;
            return new Point(newX, newY);
        }

        public static Point operator +(Point lhs, Point rhs)
        {
            float newX = lhs.X + rhs.X;
            float newY = lhs.Y + rhs.Y;
            return new Point(newX, newY);
        }
    }
}
