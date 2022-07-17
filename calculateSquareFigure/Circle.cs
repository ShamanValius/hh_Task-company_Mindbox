using System;

namespace calculateSquareFigure
{
    public class Circle : IGeometricFigure
    {
        private double radius;

        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Circle cannot be created with given parameters (Radius circle <= 0)");
            }
            this.radius = radius;
        }

        public double Square()
        {
            /// You can see the formula <see href="https://mnogoformul.ru/formuly-ploshhadi-kruga-i-raschet-onlayn#id2">here</see>.
            return 3.14f * Math.Pow(radius, 2);
        }
    }
}
