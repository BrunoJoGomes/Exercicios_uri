using System;
using System.Globalization;

namespace uri_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double velocidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double distanciaPercorrida = (velocidade * horas);
            double litros = (distanciaPercorrida / 12);

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
