using System;

namespace A_LEVEL_EXERSISE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueValueInput;
            do {
                string a;
                string b;
                string c;
                double x1 = 0;
                double x2 = 0;
                double discriminant;
                double[] results;

                Console.WriteLine("Enter a value. Value must be a number");
                a = Console.ReadLine();

                Console.WriteLine("Enter b value. Value must be a number");
                b = Console.ReadLine();

                Console.WriteLine("Enter c value. Value must be a number");
                c = Console.ReadLine();

                int intA = int.Parse(a);
                int intB = int.Parse(b);
                int intC = int.Parse(c);

                discriminant = Math.Pow(intB, 2) - 4 * intA * intC;

                if (discriminant < 0)
                {
                    Console.WriteLine("The equation hasn't x1, x2");
                }
                if (discriminant == 0)
                {
                    x1 = -intB / (2 * intA);

                    Console.WriteLine($"The X1 is:  {x1}");
                }
                else if (discriminant > 0)
                {
                    x1 = (-intB + Math.Sqrt(discriminant)) / (2 * intA);
                    x2 = (-intB - Math.Sqrt(discriminant)) / (2 * intA);

                    Console.WriteLine($"The X1 is:  {x1}");
                    Console.WriteLine($"The X2 is:  {x2}");
                }

                Console.WriteLine("If you want to escape - press 1; if you want to continue - press any other key");
                string userAnswer = Console.ReadLine();

                if(Equals(userAnswer, "1"))
                {
                    continueValueInput = true;
                } else
                {
                    continueValueInput = false;
                }

            } while (continueValueInput);
        }
    }
}
