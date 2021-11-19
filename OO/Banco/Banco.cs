using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Banco
    {
        public List<Agencia> Agencias;
        public int QtdeAgencias { get; private set;}
        public int Numero { get; private set; }

        public Banco(int num)
        {            
            this.Agencias = new List<Agencia>();
            this.QtdeAgencias = 0;
            this.Numero=num;
        }

        public bool CriarAgencia()
        {
            Agencia agencia = new Agencia(++QtdeAgencias);
            this.Agencias.Add(agencia);
            return true;
        }


    }
}
