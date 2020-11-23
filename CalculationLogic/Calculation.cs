using System;

namespace CalculationLogic
{
    public class Calculation
    {
        public double calc(int a, int b, int c, out double x1, out double x2)
        {
            double discriminant;
            double[] results;
            x1 = 0;
            x2 = 0;

            discriminant = Math.Pow(b, 2) - 4 * a * c;


            if (discriminant == 0)
            {
                x1 = -b / (2 * a);
            }
            else if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }

            return discriminant;
        }
    }
}
