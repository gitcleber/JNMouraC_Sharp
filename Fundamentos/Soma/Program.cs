using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i < 5; i++)
            {
                /*Faça um programa para somar todos os numeros de um range*/

                Console.WriteLine("Digite o {0}º numero: ",i);
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Soma Total: " + soma);
            Console.ReadLine();
        }
    }
}
