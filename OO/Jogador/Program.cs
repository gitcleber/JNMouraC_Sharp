using System;

namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            //exe01
            //Crie uma classe chamada Jogador contendo os atributos nome(string), rg(string), cpf
            //(string) e endereco(string) e:
            //a) Crie um método construtor para essa classe inicializado os atributos para ""(vazio).
            //b) Instancie o objeto zequinha do tipo jogador e atribua valores para seus atributos.
            //c) Instancie o objeto mariazinha do tipo jogador e atribua valores para seus atributos.
            //Projeto Jogador

            Jogador zequinha = new Jogador();
            zequinha.nome = "Zeca";
            zequinha.rg = "40 428 345 23";
            zequinha.cpf = "346 299 555 37";
            zequinha.endereco="Rua 5";

            Jogador mariazinha = new Jogador();
            zequinha.nome = "Maria";
            zequinha.rg = "30 321 724 22";
            zequinha.cpf = "987 654 321 00";
            zequinha.endereco="Av Sete";


        }
    }
}
