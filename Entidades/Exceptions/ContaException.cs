using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades.Exceptions {
    internal class ContaException : ApplicationException {
        public ContaException(string? message) : base(message) {
        }
    }
}
