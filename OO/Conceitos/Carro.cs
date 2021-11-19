using System;
using System.Collections.Generic;
using System.Text;

namespace Carros
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

        
        public string Nome { get; private set; } //propriedade (encapsular o atributo)
        public int AnoFabricacao { get; private set; }
        public double Velocidade { get; private set; }


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
            Velocidade = 0;
        }

        public void acelerar()
        {
            Velocidade++;
            if (Velocidade > 100)
                Velocidade = 100;
        }
        public void frear()
        {
            Velocidade--;
            if (Velocidade < 0)
                Velocidade = 0;
        }

        public Carro(string nome) // função => método Construtor.
        {
            this.Nome = nome;
            Velocidade = 0;
        }

        public Carro(string nome, int anoFabricacao) // função => método Construtor.
        {
            this.Nome = nome;
            this.AnoFabricacao = anoFabricacao;
            Velocidade = 0;
        }

        public Carro(int anoFabricacao) // função => método Construtor.
        {
            this.AnoFabricacao = anoFabricacao;
            Velocidade = 0;
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
