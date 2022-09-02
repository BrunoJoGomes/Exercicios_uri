using System;

namespace uri_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int diasInformados = int.Parse(Console.ReadLine());

            int anos = diasInformados / 365;
            diasInformados -= anos * 365;

            int meses = diasInformados / 30;
            diasInformados -= meses * 30;

            int dias = diasInformados;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
