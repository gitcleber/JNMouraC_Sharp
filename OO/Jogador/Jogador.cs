using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogador
{
    class Jogador
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public Jogador()
        {
            this.Nome = "";
            this.RG = "";
            this.Endereco = "";
            this.CPF = "";
        }
    }
}
