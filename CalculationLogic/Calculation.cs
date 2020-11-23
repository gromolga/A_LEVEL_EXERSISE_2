using System;

namespace CalculationLogic
{
    public class Calculation
    {
        public double calc(string a, string b, string c, out double x1, out double x2)
        {
            double discriminant;
            double[] results;
            x1 = 0;
            x2 = 0;

            int intA = int.Parse(a);
            int intB = int.Parse(b);
            int intC = int.Parse(c);

            discriminant = Math.Pow(intB, 2) - 4 * intA * intC;


            if (discriminant == 0)
            {
                x1 = -intB / (2 * intA);
            }
            else if (discriminant > 0)
            {
                x1 = (-intB + Math.Sqrt(discriminant)) / (2 * intA);
                x2 = (-intB - Math.Sqrt(discriminant)) / (2 * intA);
            }

            return discriminant;
        }
    }
}
