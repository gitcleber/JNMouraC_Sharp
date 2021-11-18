using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador zequinha = new Jogador();
            zequinha.CPF = "29368591855";
            zequinha.Nome = "Zeca";
            zequinha.Endereco = "Rua 1";
            zequinha.RG = "1321654x";

            Jogador mariazinha = new Jogador();
            mariazinha.CPF = "29368591856";
            mariazinha.Nome = "Maria";
            mariazinha.Endereco = "Rua 1";
            mariazinha.RG = "13216540";

            Console.WriteLine("Jogador Zequinha=> Nome: {0}", zequinha.Nome);
            Console.WriteLine("Jogador Mariazinha=> Nome: {0}", mariazinha.Nome);

            Console.ReadLine();
        }
    }
}
