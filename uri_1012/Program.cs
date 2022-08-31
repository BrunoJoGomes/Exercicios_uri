using System;

namespace uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string valores = Console.ReadLine();
            string[] separacaoValores = valores.Split(' ');

            double triangulo = (double.Parse(separacaoValores[0], System.Globalization.CultureInfo.InvariantCulture) * double.Parse(separacaoValores[2], System.Globalization.CultureInfo.InvariantCulture)) / 2;

            double circulo = 3.14159 * Math.Pow(Double.Parse(separacaoValores[2], System.Globalization.CultureInfo.InvariantCulture), 2);

            double trapezio = (double.Parse(separacaoValores[0], System.Globalization.CultureInfo.InvariantCulture) + double.Parse(separacaoValores[1], System.Globalization.CultureInfo.InvariantCulture)) * double.Parse(separacaoValores[2]) / 2;

            double quadrado = double.Parse(separacaoValores[1], System.Globalization.CultureInfo.InvariantCulture) * double.Parse(separacaoValores[1], System.Globalization.CultureInfo.InvariantCulture);

            double retangulo = double.Parse(separacaoValores[0], System.Globalization.CultureInfo.InvariantCulture) * double.Parse(separacaoValores[1], System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
