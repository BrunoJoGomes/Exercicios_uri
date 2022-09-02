using System;
using System.Globalization;
namespace uri_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorRecebido = double.Parse(Console.ReadLine());
            double valor = valorRecebido;
            double notas2 = 0, notas5 = 0, notas10 = 0, notas20 = 0, notas50 = 0, notas100 = 0;
            double moeda1Real = 0, moeda50Cents = 0, moeda25Cents = 0, moeda10Cents = 0, moeda5Cents = 0, moeda1cents = 0;


            if (valor >= 100)
            {
                notas100 = valor / 100;
                valor -= 100 * notas100;



            }
            if (valor >= 50)
            {
                notas50 = valor / 50;
                valor -= 50 * notas50;
            }
            if (valor >= 20)
            {
                notas20 = valor / 20;
                valor -= 20 * notas20;
            }
            if (valor >= 10)
            {
                notas10 = valor / 10;
                valor -= 10 * notas10;
            }
            if (valor >= 5)
            {
                notas5 = valor / 5;
                valor -= 5 * notas5;
            }
            if (valor >= 2)
            {
                notas2 = valor / 2;
                valor -= 2 * notas2;
            }
            if (valor >= 1)
            {
                 moeda1Real = valor / 1;
                valor -= 1 * moeda1Real;

            }
            
            double valorCents = valor;

            if (valorCents >= 0.50)
            {

                moeda50Cents = valor / 0.50;
                valorCents -= 0.50 * moeda50Cents;
            }
            if (valorCents >= 0.25)
            {
                moeda25Cents = valor / 0.25;
                valorCents -= 0.25 * moeda25Cents;
            }
            if (valorCents >= 0.10)
            {
                moeda10Cents = valor / 0.10;
                valorCents -= 0.10 * moeda10Cents;
            }
            if (valorCents >= 0.05)
            {
                moeda5Cents = valor / 0.05;
                valorCents -= 0.05 * moeda5Cents;
            }
            if (valorCents >= 0.01)
            {
                moeda1cents = valor / 0.01;
                valorCents -= 0.01 * moeda1cents;
            }

            Console.WriteLine(valorRecebido);
            Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2.00");
            Console.WriteLine(moeda1Real.ToString("F2", CultureInfo.InvariantCulture)+ " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50Cents.ToString("F2", CultureInfo.InvariantCulture) + " moeda(s) de R$ 50.00");
            Console.WriteLine(moeda25Cents.ToString("F2", CultureInfo.InvariantCulture) + " moeda(s) de R$ 25.00");
            Console.WriteLine(moeda10Cents.ToString("F2", CultureInfo.InvariantCulture) + " moeda(s) de R$ 10.00");
            Console.WriteLine(moeda5Cents.ToString("F2", CultureInfo.InvariantCulture) + " moeda(s) de R$ 5.00");
            Console.WriteLine(moeda1cents.ToString("F2", CultureInfo.InvariantCulture) + " moeda(s) de R$ 1.00");
        }
    }
}
