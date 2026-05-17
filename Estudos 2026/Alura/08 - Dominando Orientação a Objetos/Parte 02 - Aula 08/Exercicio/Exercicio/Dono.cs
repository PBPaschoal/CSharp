using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio {
    internal class Dono {
        public string Nome { get; set; }
        public string Contato { get; set; }

        public Dono(string nome, string contato) {
            Nome = nome;
            Contato = contato;
        }
    }
}
