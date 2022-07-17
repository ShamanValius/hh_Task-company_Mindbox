using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateSquareFigure
{
    internal class Triangle : IGeometricFigure 
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("One of the sides is less than or equal to zero");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("Triangle cannot be created with given parameters");
            }
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }

            public double Square()
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }
    }
}
