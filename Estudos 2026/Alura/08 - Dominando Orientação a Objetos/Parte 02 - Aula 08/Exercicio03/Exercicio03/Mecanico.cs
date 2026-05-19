using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03 {
    internal class Mecanico {
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public Mecanico(string nome, string especialidade) {
            Nome = nome;
            Especialidade = especialidade;
        }
    }
}
