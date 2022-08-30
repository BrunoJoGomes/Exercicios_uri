using System;
using System.Globalization;

namespace uni_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoA = 2;
            double pesoB = 3;
            double pesoC = 5;
            double pesos = 10;

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ((a * pesoA) + (b * pesoB) + (c * pesoC)) / pesos;

            Console.WriteLine($"MEDIA = {resultado.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
