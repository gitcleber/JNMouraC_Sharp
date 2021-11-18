using System;
using System.Collections.Generic;
using System.Text;

namespace Jogador
{//exe01
 //Crie uma classe chamada Jogador contendo os atributos nome(string), rg(string), cpf
 //(string) e endereco(string) e:
 //a) Crie um método construtor para essa classe inicializado os atributos para ""(vazio).
 //b) Instancie o objeto zequinha do tipo jogador e atribua valores para seus atributos.
 //c) Instancie o objeto mariazinha do tipo jogador e atribua valores para seus atributos.
 //Projeto Jogador

    class Jogador
    {
        public string nome;
        public string rg;
        public string cpf;
        public string endereco;

        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public Jogador()
        {
            this.nome = "";
            this.rg = "";
            this.cpf = "";
            this.endereco = "";
        }
        

    }
}
