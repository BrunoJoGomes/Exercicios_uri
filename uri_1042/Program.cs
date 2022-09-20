using System;

namespace uri_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split();

            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int n3 = int.Parse(numeros[2]);

            int maior = 0;
            int menor = 0;
            int meio = 0;
            
            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
                if (n2 < n3)
                {
                    menor = n2;
                    meio = n3;
                }
                else
                {
                    menor = n3;
                    meio = n2; 
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                maior = n2;
                if (n1 < n3)
                {
                    menor = n1;
                    meio = n3;
                }
                else
                {
                    menor = n3;
                    meio = n1;
                }
            }
            else if (n3 > n1 && n3 > n2)
            {
                maior = n3;
                if (n1 < n2)
                {
                    menor = n1;
                    meio = n2;
                }
                else
                {
                    menor = n2;
                    meio = n1;
                }
            }
            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);








        }
    }
}
