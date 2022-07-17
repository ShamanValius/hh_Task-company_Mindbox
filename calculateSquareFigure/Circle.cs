using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateSquareFigure
{
    public class Circle : IGeometricFIgure
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Square()
        {
            return Math.Round(3.14f * Math.Pow(Radius, 2), 1);
        }
    }
}
