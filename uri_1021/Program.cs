using System;
using System.Globalization;
namespace uri_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valorRecebido = Console.ReadLine().Split('.');
            int reais = int.Parse(valorRecebido[0]);
            int centavos = int.Parse(valorRecebido[1]);

            int notas2 = 0, notas5 = 0, notas10 = 0, notas20 = 0, notas50 = 0, notas100 = 0;
            int moedas1 = 0, moedas50 = 0, moedas25 = 0, moedas10 = 0, moedas5 = 0, moedas1Cent = 0;


            if (reais >= 100)
            {
                notas100 = reais / 100;
                reais -= 100 * notas100;
            }
            if (reais >= 50)
            {
                notas50 = reais / 50;
                reais -= 50 * notas50;
            }
            if (reais >= 20)
            {
                notas20 = reais / 20;
                reais -= 20 * notas20;
            }
            if (reais >= 10)
            {
                notas10 = reais / 10;
                reais -= 10 * notas10;
            }
            if (reais >= 5)
            {
                notas5 = reais / 5;
                reais -= 5 * notas5;
            }
            if (reais >= 2)
            {
                notas2 = reais / 2;
                reais -= 2 * notas2;
            }
            if (reais >= 1)
            {
                moedas1 = reais / 1;
                reais -= 1 * moedas1;
            }
            if (centavos >= 50)
            {
                moedas50 = centavos / 50;
                centavos -= 50 * moedas50;
            }
            if (centavos >= 25)
            {
                moedas25 = centavos / 25;
                centavos -= 25 * moedas25;
            }
            if (centavos >= 10)
            {
                moedas10 = centavos / 10;
                centavos -= 10 * moedas10;
            }
            if (centavos >= 5)
            {
                moedas5 = centavos / 5;
                centavos -= 5 * moedas5;
            }
            if (centavos >= 1)
            {
                moedas1Cent = centavos / 1;
                centavos -= 1 * moedas1Cent;
            }

            Console.WriteLine("NOTAS:");
            Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moedas1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moedas50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moedas25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moedas10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moedas5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moedas1Cent + " moeda(s) de R$ 0.01");
        }
    }
}
