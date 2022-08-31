using System;
using System.Globalization;

namespace uni_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = ((vendas * 0.15) + salarioFixo);

            Console.WriteLine("TOTAL = R$ " + comissao.ToString("F2", CultureInfo.InvariantCulture));
         }
    }
}
