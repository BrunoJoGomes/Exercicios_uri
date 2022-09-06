using System;

namespace uri_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lados = Console.ReadLine().Split(' ');

            double lado1 = double.Parse(lados[0]);
            double lado2 = double.Parse(lados[1]);
            double lado3 = double.Parse(lados[2]);
            double perimetroTriangulo = 0;

            if (lado1 + lado2 > lado3 || lado2 + lado3 > lado1 || lado3 + lado1 > lado2)
            {
                perimetroTriangulo = lado1 + lado2 + lado3;
            }
            else
            {
               
            }
        }
    }
}
