using System;

namespace uri_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');
            double X = double.Parse(coordenadas[0]);
            double Y = double.Parse(coordenadas[1]);

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            if (X == 0 && Y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            if (Y == 0 && X != 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
