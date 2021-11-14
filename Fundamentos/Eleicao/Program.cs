using System;

namespace Eleicao
{
    class Program
    {
        static void Main(string[] args)
        {/*
             * exe01
            Em uma eleição presidencial, existem quatro candidatos. 
            Os votos são informados através de códigos.
            Os códigos utilizados são:
            - 1,2,3,4 votos para os respectivos candidatos;
            - 5 voto nulo;
            - 6 voto em branco.
            Assim, escreva um programa para receber um voto e imprima:
            - Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
            - Se o usuário votou nulo: "Voto nulo contabilizado..."
            - Se o usuário votou em branco: "Voto branco contabilizado..."
            Projeto: Eleicao
            10min
            */

            int cand1, cand2, cand3, cand4, nulo, branco;

            Console.Write("Digite seu Voto:");
            int voto = Convert.ToInt16(Console.ReadLine());

            if ((voto >= 1)&(voto<=4))
            {
                Console.WriteLine("Voto computado com sucesso");
            }
            else if (voto == 5)
            {
                Console.WriteLine("Voto Nulo - computado");
            }
            else if (voto == 6)
            {
                Console.WriteLine("Voto Branco - computado");
            }
            else
            {
                Console.WriteLine("Voto Inválido");
            }
            Console.ReadLine();
        }
    }
}
