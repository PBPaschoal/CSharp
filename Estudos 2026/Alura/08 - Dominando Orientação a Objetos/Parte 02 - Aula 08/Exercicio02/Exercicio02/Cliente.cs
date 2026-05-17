using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02 {
    internal class Cliente {
        public string Nome { get; set; }
        public string Contato { get; set; }

        public Cliente(string nome, string contato) {
            Nome = nome;
            Contato = contato;
        }
    }
}
