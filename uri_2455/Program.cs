using System;

namespace uri_2455
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pesos = Console.ReadLine().Split();

            int P1 = int.Parse(pesos[0]);
            int C1 = int.Parse(pesos[1]);
            int P2 = int.Parse(pesos[2]);
            int C2 = int.Parse(pesos[3]);

            if (P1 * C1 == P2 * C2)
            {
                Console.WriteLine("0");
            }

            if (P1 * C1 > P2 * C2)
            {
                Console.WriteLine("-1");
            }

            if (P1 * C1 < P2 * C2)
            {
                Console.WriteLine("1");
            }

        }
    }
}
