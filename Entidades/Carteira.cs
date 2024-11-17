using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades {
    internal class Carteira {
        public double Saldo { get;  set; }

        public Carteira() {
            Saldo = 0;
        }

        public Carteira(double saldo) {
            Saldo = saldo;
        }
    }
}
