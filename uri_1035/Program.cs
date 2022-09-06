using System;

namespace uri_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int A = int.Parse(numeros[0]);
            int B = int.Parse(numeros[1]);
            int C = int.Parse(numeros[2]);
            int D = int.Parse(numeros[3]);


            if (A % 2 == 0 && B > C && D > A && C + D > A + B && C > 0 && D > 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
