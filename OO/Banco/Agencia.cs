using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Agencia
    {
        public List<Conta> Contas { get; private set; }
        public int QtdeContas { get; private set; }
        public int Numero { get; private set; }

        public Agencia(int num)
        {            
            this.Contas = new List<Conta>();
            this.QtdeContas = 0;
            this.Numero=num;
        }
        public bool CriarConta()
        {
            return true;
        }

    }
}
