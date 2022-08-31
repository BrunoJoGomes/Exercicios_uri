using System;
using System.Globalization;

namespace uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod1 = Console.ReadLine();
            string[] vetorProd1 = prod1.Split(' ');
            string prod2 = Console.ReadLine();
            string[] vetorProd2 = prod2.Split(' ');

            int numeroPeca1 = int.Parse(vetorProd1[1]);
            float valorPeca1 = float.Parse(vetorProd1[2], CultureInfo.InvariantCulture);
            
            int numeroPeca2 = int.Parse(vetorProd2[1]);
            float valorPeca2 = float.Parse(vetorProd2[2], CultureInfo.InvariantCulture);

            float total = (valorPeca1 * numeroPeca1) + (valorPeca2 * numeroPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
