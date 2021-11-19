using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Conta
    {
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int num, double saldo) {
            this.Numero=num;
            this.Saldo=saldo;
        }
    }
}
