using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio {
    internal class Pet {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especie { get; set; }

        public Pet(string nome, int idade, string especie) {
            Nome = nome;
            Idade = idade;
            Especie = especie;
        }
    }
}
