using System;
using System.Collections.Generic;
using System.Text;

namespace Conceitos
{
    class Carro
    {

        /*
         * Atributos: encapsulados
         * privados.
         * 
         * Modificadores de acesso
         * public => acesso na classe e tb externo.
         * private => acesso somente na classe.
         * Caso o modificador de acesso do atributo seja omitido, este
         * será considerado como private.
         * 
         * 
         * CUIDADO: ATRIBUTOS PÚBLICOS SÃO EXTREMAMENTE PERIGOSOS.
         * 
         */

        string nome;
        //int anoFabricacao;
        //double velocidade;
        public string Nome { get; set; } //propriedade (encapsular o atributo)
        public int AnoFabricacao { get; set; }
        public double Velocidade { get; }


        /*
         Sobrecarga => Quando algo desemepenha mais de uma função
         construtor Carro (4 formas diferentes de trabalhar com o construtor neste caso).
         esse conceito tb é utilizado para outras funções.

         Sobrecarga: Função (método construtor / método) na mesma classe, com o mesmo nome, 
         recebendo parâmetros diferentes (quantidade ou tipo)
         No entanto, quando a quantidade de parâmetros for a mesma,
         os tipos devem ser diferentes ou ter a ordem de chamada diferente.

         Sobrecarga: Funções com o mesmo nome, na mesma classe, mas com assinaturas diferentes.
         */

        public Carro() // função => método Construtor.
        {

        }

        public Carro(string nome) // função => método Construtor.
        {
            this.Nome = nome;
        }

        public Carro(string nome, int anoFabricacao) // função => método Construtor.
        {
            this.Nome = nome;
            this.AnoFabricacao = anoFabricacao;
        }

        public Carro(int anoFabricacao) // função => método Construtor.
        {
            this.AnoFabricacao = anoFabricacao;
        }

        

        
        //public void setNome(string nome) //função => método.
        //{
        //    //if (nome.Length < 61)
        //    this.nome = nome;
        //} 

        //public string getNome()
        //{
        //    return this.nome;
        //}

        //public void setAnoFabricacao(int anoFabricacao) //função => método.
        //{
        //    this.anoFabricacao = anoFabricacao;
        //}

        //public int getAnoFabricacao()
        //{
        //    return this.anoFabricacao;
        //}

    }
}
