using System;

namespace Porta
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("Hello World!");
            Porta porta1 = new Porta();
            Console.WriteLine($"Porta está Aberta?: {porta1.Aberta}");            
            porta1.Abrir();
            porta1.Abrir();
            Console.WriteLine($"A porta esta Aberta?: {porta1.Aberta}");
            porta1.Fechar();
            Console.WriteLine($"A porta está Aberta?: {porta1.Aberta}");

            porta1.Pintar("azul");
            Console.WriteLine($"A porta está na cor: {porta1.Cor}");



            Console.ReadLine();

        }
    }
}
