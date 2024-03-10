namespace GeometryLibrary
{
    public class CalculatorSquare//этот клас по сути не нужен, легче просто у самих фигур методы вызывоть, но по тексту "Вычисление площади фигуры без знания типа фигуры в compile-time" задания он необходим. Есди имелось ввиду определять фигуру по аргументам то это плохо маштабируется        
    {
        public double GetSquare(IFigure figure)
        {
            return figure.GetSquare();
        }
    }
}