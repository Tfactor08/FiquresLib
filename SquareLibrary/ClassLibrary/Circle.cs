using System;

namespace ClassLibrary
{
    public class Circle : Figure
    {
        public double R { get; private set; }

        public Circle(double r)
        {
            R = r;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
