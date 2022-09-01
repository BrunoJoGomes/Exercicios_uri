using System;
using System.Globalization;

namespace uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            double combGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = distancia / combGasto;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l" );
        }
    }
}
