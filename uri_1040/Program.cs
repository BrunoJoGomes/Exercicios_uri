using System;
using System.Globalization;

namespace uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {

            double peso1 = 2;
            double peso2 = 3;
            double peso3 = 4;
            double peso4 = 1;
            double pesos = 10;



            string[] notas = Console.ReadLine().Split(' ');
            double nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            double nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            double nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            double nota4 = double.Parse(notas[3], CultureInfo.InvariantCulture);



            double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3 + nota4 * peso4) / pesos;

            if (media == 4.85)
            {
                media = 4.8; 
            }
            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double mediaExame = (media + notaExame) / 2;
                if (mediaExame >= 5.0)
                {
                    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
                if (mediaExame <= 4.9)
                {
                    Console.WriteLine("Nota do exame: " + notaExame);
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
