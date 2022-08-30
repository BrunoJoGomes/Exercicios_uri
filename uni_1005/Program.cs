using System;
using System.Globalization;

namespace uni_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso1 = 3.5;
            double peso2 = 7.5;
            double pesos = 11;

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ((a * peso1) + (b * peso2)) / pesos;

            Console.WriteLine($"MEDIA = {resultado.ToString("F5", CultureInfo.InvariantCulture)}");



        }
    }
}
