using System;

namespace uri_2791
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] copos = Console.ReadLine().Split();

            int C1 = int.Parse(copos[0]);
            int C2 = int.Parse(copos[1]);
            int C3 = int.Parse(copos[2]);
            int C4 = int.Parse(copos[3]);

            if (C1 == 1)
            {
                Console.WriteLine("1");
            }

            if (C2 == 1)
            {
                Console.WriteLine("2");
            }

            if (C3 == 1)
            {
                Console.WriteLine("3");
            }

            if (C4 == 1)
            {
                Console.WriteLine("4");
            }
        }
    }
}
