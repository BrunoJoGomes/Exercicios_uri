using System;

namespace uri_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            if (num >= 0 && num <= 25.0000000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            if (num > 25.0000000 && num <= 50.0000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            if (num > 50.0000000 && num <= 75.0000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            if (num > 75.0000000 && num <= 100.0000000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            if (num > 100.0000000)
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
