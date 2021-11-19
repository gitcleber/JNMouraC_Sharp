using System;

namespace Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro monza = new Carro("Monzão", 2019);

            Console.WriteLine($"Carro nome: {monza.Nome}\n Carro ano: {monza.AnoFabricacao}");

            for (int i = 0; i < 10; i++)
            {
                monza.acelerar(); 
            }
            Console.WriteLine($"{monza.Velocidade}");

            for (int i = 0; i < 5; i++)
            {
                monza.frear();
            }
            Console.WriteLine($"{monza.Velocidade}");

            for (int i = 0; i < 10; i++)
            {
                monza.frear();
                Console.WriteLine($"{monza.Velocidade}");
            }           

            Console.ReadLine();

        }
    }
}
