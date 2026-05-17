using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02 {
    internal class Veiculo {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }

        public Veiculo(string marca, string modelo, int ano, string placa) {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Placa = placa;
        }
    }
}
