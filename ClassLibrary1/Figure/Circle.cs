using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Figure
{
    public class Circle : IFigure
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            if (!Validation(radius))
                throw new ArgumentException("Неверно указан радиус");
            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Radius * Radius; ;
        }

        private bool Validation(double radius)
        {
            if (radius < 0)
                return false;
            return true;
        }
    }
}
