using System;
using System.Windows;

namespace UlrichEngine
{
    public class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D(double x, double y)
        { X = x; Y = y; }

        public static Vector2D normalize(Vector2D v)
        {
            
                double magnitude = Math.Sqrt(v.X * v.X + v.Y * v.Y);
                if (magnitude > 0)
                {
                    v.X /= magnitude;
                    v.Y /= magnitude;
                }
                return v;
        }
    }
}

