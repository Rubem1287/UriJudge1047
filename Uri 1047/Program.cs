using System;

namespace Uri_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m;

            string[] vetor = Console.ReadLine().Split(' ');
            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            int c = int.Parse(vetor[2]);
            int d = int.Parse(vetor[3]);

            h = c - a;

            m = d - b;

            if( h == 0)
            {
                h = 24;
            }

            if(m<0)
            {
                m = 60 + m;
                h += -1;
            }

            Console.WriteLine("O jogo durou "+h+" hora(s) e "+m+" minuto(s)");
        }
    }
}
