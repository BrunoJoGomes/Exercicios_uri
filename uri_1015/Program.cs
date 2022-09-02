using System;
using System.Globalization;

namespace uri_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valoresX = Console.ReadLine().Split(' ');
            double valorX1 = double.Parse(valoresX[0], CultureInfo.InvariantCulture);
            double valorY1 = double.Parse(valoresX[1], CultureInfo.InvariantCulture);

            string[] valoresY = Console.ReadLine().Split(' ');
            double valorX2 = double.Parse(valoresY[0], CultureInfo.InvariantCulture);
            double valorY2 = double.Parse(valoresY[1], CultureInfo.InvariantCulture);

            double conta = Math.Sqrt(Math.Pow(valorX2 - valorX1, 2.00) + Math.Pow(valorY2 - valorY1, 2.00));

            Console.WriteLine(conta.ToString("F4", CultureInfo.InvariantCulture));
            


        }
    }
}
