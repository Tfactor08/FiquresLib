using System;

namespace ClassLibrary
{
    public class Triangle : Figure
    {
        public double[] Sides { get; private set; } = new double[3];

        public Triangle(double[] sides)
        {
            for (int i = 0; i < Sides.Length; i++)
            {
                Sides[i] = sides[i];
            }
        }

        public override double Square()
        {
            double ab = Sides[0];
            double bc = Sides[1];
            double ac = Sides[2];

            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }
    }
}
