using System;

namespace uri_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());

            double vol = (4 / 3.0) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + vol.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
