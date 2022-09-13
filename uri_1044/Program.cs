using System;

namespace uri_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split();

            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);

            if (n2 % n1 == 0 || n1 % n2 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
