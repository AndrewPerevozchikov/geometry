namespace GeometryLibrary.Figure
{
    public class Triangle : IFigure
    {

        private double SideMax { get; }
        private double Side2 { get; }
        private double Side3 { get; }
        public bool IsRightAngledTriangle => Math.Pow(SideMax, 2) == Math.Pow(Side2, 2) + Math.Pow(Side3, 2);

        public Triangle(double side1, double side2, double side3)
        {
            var sides = SortSides(side1, side2, side3);
            SideMax = sides.Side1;
            Side2 = sides.Side2;
            Side3 = sides.Side3;
            
            if (!Validation(SideMax, Side2, Side3)) throw new ArgumentException("Неверно указаны стороны треугольника");
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
            
            return !(sideMax >= side2 + side3);
        }

        private (double Side1, double Side2, double Side3) SortSides(double side1, double side2, double side3)
        {
            var list = new List<double>() { side1, side2, side3 };
            list.Sort();
            return (list[2], list[1], list[0]);
        }
    }
}
