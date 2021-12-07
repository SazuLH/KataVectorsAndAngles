using System;

namespace VectorsAndAngle
{
    public class Vector
    { 
        public double x { get; set; }
        public double y { get; set; }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Magnitude()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double DotProduct(Vector vectorx, Vector vectory)
        {
            return (vectorx.x*vectorx.x) + (vectory.y*vectory.y);
        }
        public double AngleBetween(Vector vectorx, Vector vectory)
        {
            return (Math.Acos(DotProduct(vectorx, vectory) / (vectorx.Magnitude() * vectory.Magnitude()))) * 180 / 3.14;
        }
    }
}
