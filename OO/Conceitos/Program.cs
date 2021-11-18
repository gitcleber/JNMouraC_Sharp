using System;

namespace Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro monza = new Carro("monza top", 2019);
            monza.Nome = "Monzão";
            Console.WriteLine("Dados do monza: nome: {0}, ano: {1}, velocidade: {2}:", monza.Nome, monza.AnoFabricacao, monza.Velocidade);

            /*
            Carro gol = new Carro();
            Carro chevete = new Carro("chevete max");
            Carro fusca = new Carro("fuscao", 1979);
            Carro fit = new Carro(2010);            
            */

            Console.ReadLine();

        }
    }
}
