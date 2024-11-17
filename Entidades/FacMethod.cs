using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades {
    internal static class FacMethod  {

        public static Conta InstanciarConta(string escolha) {

            switch(escolha) {
                case "LOJISTA": return new ContaLojista();
                case "COMUM": return new ContaComum();
                default: return null;
            }
        }
    }
}
