using System;
using System.Globalization;

namespace uri_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            double A = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double B = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            double C = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            if (A > 0 && B > 0 && C > 0)
            {
                double delta = Math.Pow(B, 2) - (4 * A * C);
                if (delta > 0)
                {
                    double X1 = ((-B) + Math.Sqrt(delta)) / (2 * A);
                    double X2 = ((-B) - Math.Sqrt(delta)) / (2 * A);

                    Console.WriteLine("R1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
                    Console.WriteLine("R2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));

                }
                else
                {
                    Console.WriteLine("Impossivel calcular");
                }
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
