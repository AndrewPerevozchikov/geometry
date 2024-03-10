namespace GeometryLibrary.Figure
{
    public class Triangle : IFigure
    {
        public bool IsRightAngledTriangle { get; private set; }
        public double SideMax { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            var sides = SortSides(side1, side2, side3);
            SideMax = sides.Item1;
            Side2 = sides.Item2;
            Side3 = sides.Item3;
            if (!Validation(SideMax, Side2, Side3))
                throw new ArgumentException("Неверно указаны стороны треугольника");
            if (SideMax * SideMax == Side2 * Side2 + Side3 * Side3)
                IsRightAngledTriangle = true;
        }

        public double GetSquare()
        {
            var P = (SideMax + Side2 + Side3) / 2d;
            return Math.Sqrt(
                P
                * (P - SideMax)
                * (P - Side2)
                * (P - Side3)
            );
        }

        private bool Validation(double sideMax, double side2, double side3)
        {
            if (sideMax <= 0 || side2 <= 0 || side3 <= 0)
                return false;
            if (sideMax >= side2 + side3)
                return false;
            return true;
        }

        private (double, double, double) SortSides(double side1, double side2, double side3)
        {
            List<double> list = new List<double>() { side1, side2, side3 };
            list.Sort();
            return (list[2], list[1], list[0]);
        }
    }
}
