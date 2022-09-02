using System;

namespace uri_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoFabrica = int.Parse(Console.ReadLine());


            int horas = tempoFabrica / 3600;
            tempoFabrica -= horas * 3600;

            int minutos = tempoFabrica / 60;
            tempoFabrica -= minutos * 60;

            int segundos = tempoFabrica;
            
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
