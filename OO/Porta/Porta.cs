using System;
using System.Collections.Generic;
using System.Text;

namespace Porta
{/*
          * * --exe02--
          * 
           Crie uma classe que atenda aos requisitos abaixo:
            Classe: Porta
            Atributos: aberta, cor
            Métodos: void abrir(), void fechar(), void pintar(string cor)
            Para testar a classe, crie um objeto porta, abra e feche a mesma e pinte‐a de diversas cores.
            Importante: Defina os tipos dos atributos conforme sua necessidade e lembre-se: uma porta que
            já está aberta não pode abrir novamente, como também, uma porta que já está fechada não pode
            ser fechada novamente.
            Projeto Porta
          * */
    class Porta
    {
        public bool Aberta { get; set; }
        public string Cor { get; set; }

        public void Abrir()
        {
            if(!Aberta)
                this.Aberta = true;
            else
                Console.WriteLine("A porta já está Aberta.");
        }
        public void Fechar()
        {
            if(Aberta)
                this.Aberta = false;
            else
                Console.WriteLine("A porta já está fechada.");
        }
        public void Pintar(string cor)
        {
            this.Cor = cor;
        }
    }
}
