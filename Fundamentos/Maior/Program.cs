using System;

namespace Maior
{
    class Program
    {
        /*Faça um programa que leia 5 números inteiros informados pelo usuário e, no final, mostre o maior deles.*/

        static void Main(string[] args)
        {
            int maior = int.MinValue, num, idxNum=0;
            for (int i = 1; i < 6; i++)
            {
                Console.Write("Digite o " + i + "º numero: ");
                num = int.Parse(Console.ReadLine());
                if (maior < num)
                {
                    maior = num;
                    idxNum = i;
                }
            }
            Console.WriteLine("Maior Número é o {0} digitado na {1}ª rodada",maior, idxNum);

            Console.ReadLine();

        }
    }
}
