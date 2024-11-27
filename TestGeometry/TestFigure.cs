using GeometryLibrary;
using GeometryLibrary.Figure;

namespace TestGeometry
{
    public class TestFigure
    {
        [Theory]
        [InlineData(3, 3, 5, false, "4,14578098794425", true)]
        [InlineData(4, 5, 3, true, "6", true)]
        [InlineData(4, 5, 3, false, "6", false)]
        [InlineData(3, 2, 4, false, "6,123434256465", false)]
        [InlineData(3, 2, 7, false, "Неверно указаны стороны треугольника", true)]
        [InlineData(3, 2, 0, false, "Неверно указаны стороны треугольника", true)]
        public void TriangleTest(double side1, double side2, double side3,
            bool isRightAngledTriangle, string resultCalculateSquare, bool result)
        {
            try
            {
                var triangle = new Triangle(side1, side2, side3);
                Assert.Equal(result,
                    (resultCalculateSquare == triangle.GetSquare().ToString() &&
                    isRightAngledTriangle == triangle.IsRightAngledTriangle)
                    );
            }
            catch (ArgumentException ex)
            {
                Assert.Equal(result, resultCalculateSquare == ex.Message);
            }
        }

        [Theory]
        [InlineData(1, "3,141592653589793", true)]
        [InlineData(2, "12,566370614359172", true)]
        [InlineData(3.5, "38,48451000647496", true)]
        [InlineData(1, "3.14", false)]
        [InlineData(0, "0", true)]
        [InlineData(-1, "Неверно указан радиус", true)]
        public void CircleTest(double radius, string resultCalculateSquare, bool result)
        {
            try
            {
                var circle = new Circle(radius);
                Assert.Equal(result, (resultCalculateSquare == circle.GetSquare().ToString()));
            }
            catch (ArgumentException ex)
            {
                Assert.Equal(result, resultCalculateSquare == ex.Message);
            }
        }

    }
}