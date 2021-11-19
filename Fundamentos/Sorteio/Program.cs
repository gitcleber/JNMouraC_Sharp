using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Sorteio
{
    class Program
    {        
        /*Desenvolva um programa capaz de realizar um sorteio utilizando o intervalo de números de 1 a 60. 
        O programa deve sortear 6 números, sem repetições, dentro deste intervalo e exibi-los para o usuário.
        Projeto: Sorteio
        --- Função Random --
        Random roleta = new Random();
        Pensar em como não repetir sorteios para numeros que ja forma sorteados
         */

        static void Main(string[] args)
        {
            int[] numSorteados = new int[6];
            int num, qtdeRepetidos = 0;
            Random rnd = new Random();
/*
            for (int i = 0; i < numSorteados.Length; i++)
            {
                do
                {
                    num = rnd.Next(0, numSorteados.Length+1);//sorteia um numero.
                    if (numSorteados.Contains(num))//verifica se número sorteado ja existe no vetor
                    {
                        qtdeRepetidos++;
                        continue;//Se existir volta para o inicio do loop 'do' para sortear um outro número
                    }
                    numSorteados[i] = num;//aloca numero sorteado no vetor
                    break;//interrompe o sorteio e volta pro loop 'for'.

                } while (true);

                Console.WriteLine($"Numero {i + 1}: {numSorteados[i]}");
            }

            Console.WriteLine($"Repetições: {qtdeRepetidos  }");
            */
            //Gerando sorteio versão 2
            for (int i = 0; i < numSorteados.Length; i++)//criando um array com os numeros do range desejado
            {
                numSorteados[i] = i;
            }
            // vamos embaralhar o ArrayList
            for (int i = 0; i < numSorteados.Length; i++)
            {
                int a = rnd.Next(numSorteados.Length);
                int temp = numSorteados[i];
                numSorteados[i] = numSorteados[a];
                numSorteados[a] = temp;
            }

            foreach (int e in numSorteados)//imprime os numeros sorteados
                Console.WriteLine(e);

            //Array.Sort(numSorteados);//organiza em ordem crescente

            //foreach (int e in numSorteados)//imprime em ordem crescente
            //    Console.WriteLine(e);

            Console.ReadLine();

        }
    }
}
