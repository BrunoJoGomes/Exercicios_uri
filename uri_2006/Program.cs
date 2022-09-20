using System;

namespace uri_2006
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoCha = int.Parse(Console.ReadLine());
            string[] respostas = Console.ReadLine().Split();

            int R1 = int.Parse(respostas[0]);
            int R2 = int.Parse(respostas[1]);
            int R3 = int.Parse(respostas[2]);
            int R4 = int.Parse(respostas[3]);
            int R5 = int.Parse(respostas[4]);

            int pontos = 0;
            int pontos1 = 0;
            int pontos2 = 0;
            int pontos3 = 0;
            int pontos4 = 0;
            int pontos5 = 0;

            foreach (string i in respostas)
            {
                if (R1 == tipoCha)
                {
                    pontos1 = (pontos + 1);
                }

                if (R2 == tipoCha)
                {
                    pontos2 = (pontos + 1);
                }

                if (R3 == tipoCha)
                {
                    pontos3 = (pontos + 1);
                }

                if (R4 == tipoCha)
                {
                    pontos4 = (pontos + 1);
                }

                if (R5 == tipoCha)
                {
                    pontos5 = (pontos + 1);
                }

            }

            Console.WriteLine(pontos1 + pontos2 + pontos3 + pontos4 + pontos5);
        }
    }
}
