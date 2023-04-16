namespace Solution
{
    using System;
    public class Calculator
    {
        public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
        {
            double a = (2 * (Math.PI)) / (numberOfSides);
            double area = 0.500 * numberOfSides * circleRadius * circleRadius * Math.Sin(a);
            return Math.Round(area * 1000) / 1000;
        }
    }
}
