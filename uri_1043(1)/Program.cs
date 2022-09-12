using System;
using System.Globalization;

namespace uri_1043_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string[] lados = Console.ReadLine().Split(' ');

                double A = double.Parse(lados[0], CultureInfo.InvariantCulture);
                double B = double.Parse(lados[1], CultureInfo.InvariantCulture);
                double C = double.Parse(lados[2], CultureInfo.InvariantCulture);

                if (A + B > C && B + C > A && A + C > B)
                {
                    double perimetroTriangulo = (A + B + C);
                    Console.WriteLine("Perimetro = " + perimetroTriangulo.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    double areaTrapezio = (A + B) * C / 2;
                    Console.WriteLine("Area = " + areaTrapezio.ToString("F1", CultureInfo.InvariantCulture));
                }
            
        }
    }
}
    

