using System;

namespace uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorRecebido = int.Parse(Console.ReadLine());

            int notas1 = 0, notas2 = 0, notas5 = 0, notas10 = 0, notas20 = 0, notas50 = 0, notas100 = 0, valor = valorRecebido;


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
                notas1 = valor / 1;
                valor -= 1 * notas1;
            }

            Console.WriteLine(valorRecebido);
            Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2,00");
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");

        }
    }
}
