using System;
using System.Globalization;

namespace uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salFinal = salario * horas;

            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine($"SALARY = U$ {salFinal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
