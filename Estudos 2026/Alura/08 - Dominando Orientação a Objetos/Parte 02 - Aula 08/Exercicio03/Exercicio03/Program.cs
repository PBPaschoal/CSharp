/* Criar um programa Program.cs e simular o funcionamento do programa. */

using Exercicio03;
using System;

internal class Program {

    public static void Main(string[] args) {
        Veiculo meuCarro = new Veiculo("Chevrolet", "Cruze", 2020, "ABC1234");
        Cliente cliente = new Cliente("Carlos", "987654321");
        Mecanico mecanico = new Mecanico("Mário", "Mecânica Geral");
        Oficina oficina = new Oficina();

        // Agendar e realizar um serviço na oficina
        oficina.AgendarServico(meuCarro, cliente, mecanico, "2023-12-18");
        oficina.RealizarServico(meuCarro, mecanico);
    }
}