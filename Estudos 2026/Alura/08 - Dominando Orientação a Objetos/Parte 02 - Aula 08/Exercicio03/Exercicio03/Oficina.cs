using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Exercicio03 {
    internal class Oficina {
        private List<Veiculo> veiculosNaOficina;

        public Oficina() { 
            veiculosNaOficina = new List<Veiculo>();
        }

        public void AgendarServico(Veiculo veiculo, Cliente cliente, Mecanico mecanico, string dataAgendamento) {
            veiculosNaOficina.Add(veiculo);
            Console.WriteLine($"Serviço agendado para {veiculo.Placa} em {dataAgendamento} com o mecânico {mecanico.Nome}");
        }

        public void RealizarServico(Veiculo veiculo, Mecanico mecanico) {
            if (veiculosNaOficina.Contains(veiculo)) {
                Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo mecânico {mecanico.Nome}.");
                veiculosNaOficina.Remove(veiculo);
            } else {
                Console.WriteLine($"O veículo {veiculo.Placa} não está na oficina para realizar o serviço.");
            }
        }
    }
}
