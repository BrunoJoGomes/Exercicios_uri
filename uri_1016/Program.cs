using System;

namespace uri_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            
            double kmPercorridoX = 0;
            double kmPercorridoY = 0;

            int minutos = 0;
            double distanciaEntreXeY = 0;

            while (distanciaEntreXeY < distancia)
            {
                kmPercorridoX += 1;
                kmPercorridoY += 1.5;
                distanciaEntreXeY = kmPercorridoY - kmPercorridoX;
                minutos += 1;
            }
            Console.WriteLine(minutos + "minutos");

        }
    }
}
