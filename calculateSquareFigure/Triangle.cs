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

        /// <param name="a">A side length of a triangle</param>
        /// <param name="b">B side length of a triangle</param>
        /// <param name="c">C side length of a triangle</param>
        /// <exception cref="ArgumentException"></exception>
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
            /// You can see the formula <see href="https://mnogoformul.ru/ploshhad-treugolnika-formuly-i-kalkulator-online?ysclid=l5p3pszajs829884380#id1-6">here</see>.
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }

        public bool IsRightTriangle()
        {
            double[] SideTriangle = new double[3] { sideA, sideB, sideC };
            Array.Sort(SideTriangle);

            /// You can see the formula <see href="https://en.wikipedia.org/wiki/Right_triangle">here</see>.
            return Math.Pow(SideTriangle[0], 2) + Math.Pow(SideTriangle[1], 2) == Math.Pow(SideTriangle[2], 2);
        }
    }
}
