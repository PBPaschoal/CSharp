using System;
using System.Collections.Generic;
using System.Text;

namespace Program {
    internal class Carro {
        public string Modelo { get; set; }
        public string Cor {  get; set; }

        public Carro(string modelo, string cor) {
            Modelo = modelo;
            Cor = cor;
        }
    }
}
