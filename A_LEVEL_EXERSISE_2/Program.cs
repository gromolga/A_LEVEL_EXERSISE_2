using System;

namespace A_LEVEL_EXERSISE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            string c;
            double x1;
            double x2;

            Console.Write("Enter A value (value must be numeric): ");
            a = Console.ReadLine();

            Console.Write("Enter B value (value must be numeric): ");
            b = Console.ReadLine();

            Console.Write("Enter C value (value must be numeric): ");
            c = Console.ReadLine();

            Console.WriteLine($"a is: {a}; b is: {b}; c is: {c};");
        }
    }
}
