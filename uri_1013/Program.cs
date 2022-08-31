using System;

namespace uri_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string valores = (Console.ReadLine());
            string[] valoresSeparados = valores.Split(' ');

            int a = int.Parse(valoresSeparados[0]);
            int b = int.Parse(valoresSeparados[1]);
            int c = int.Parse(valoresSeparados[2]);

            int conta = (a + b + Math.Abs(a - b)) / 2;
            int conta2 = (c + conta + Math.Abs(c - conta)) / 2;

            Console.WriteLine(conta2 + " eh o maior");




        }
    }
}
