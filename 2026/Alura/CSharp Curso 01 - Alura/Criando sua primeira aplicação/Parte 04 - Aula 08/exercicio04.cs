//Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
using System;
using System.Collections.Generic;
class Program {
    public static void Main(string[] args) {
        MenuCadastro();
    }
    static void MenuCadastro() {
        Dictionary<string, int> cadastroDeSenhas = new Dictionary<string, int>();
        int repetir;
        do {
            Console.Write("Digite o nome de usuário: ");
            string nomeUsuario = Console.ReadLine();
            Console.Write("Digite a senha (apenas números): ");
            int senhaUsuario = int.Parse(Console.ReadLine());
            cadastroDeSenhas.Add(nomeUsuario, senhaUsuario);
            Console.Write("\nDeseja cadastrar um novo usuário? 1 = SIM / 2 = NÃO");
            repetir = int.Parse(Console.ReadLine());
        } while (repetir == 1);
        Console.WriteLine("\nUsuários cadastrados:");
        foreach(var cadastro in cadastroDeSenhas) {
            Console.WriteLine($"Usuário: {cadastro.Key} | Senha: {cadastro.Value}");
        }
    }
}