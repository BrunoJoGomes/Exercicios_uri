using System;

namespace uri_2374
{
    class Program
    {
        static void Main(string[] args)
        {
            int pressaoDesejada = int.Parse(Console.ReadLine());
            int pressaoLida = int.Parse(Console.ReadLine());

            Console.WriteLine(pressaoDesejada - pressaoLida);
        }
    }
}
