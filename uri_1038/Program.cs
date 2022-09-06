using System;
using System.Globalization;

namespace uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int prod = int.Parse(entrada[0]);
            int quant = int.Parse(entrada[1]);

            double CQ1 = 4.00;
            double XS2 = 4.50;
            double XB3 = 5.00;
            double T4 = 2.00;
            double R5 = 1.50;
            double valor = 0;

            if (prod == 1)
            {
                valor = CQ1 * quant;
            }
            if (prod == 2)
            {
                valor = XS2 * quant;
            }
            if (prod == 3)
            {
                valor = XB3 * quant;
            }
            if (prod == 4)
            {
                valor = T4 * quant;
            }
            if (prod == 5)
            {
                valor = R5 * quant;
            }
            Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
