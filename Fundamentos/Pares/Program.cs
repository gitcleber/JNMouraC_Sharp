using System;

namespace Pares
{
    class Program
    {
        /* Faça um programa que imprime os numeros pares de um range exemplo(0 a 10 ou 10 a 100)*/
        static void Main(string[] args)
        {
            /*
            for (int i = 10; i < 101; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            */
            for (int i = 10; i < 101; i += 2)
                Console.WriteLine(i);
        }
    }
}
