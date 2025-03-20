using System;

using System.Collections.Generic;

class Program {

    static List<string> usuarios = new List<string>();

    static void Main() {

        while (true) {
            Console.WriteLine("\n=== CRUD de Usuários ===");
            Console.WriteLine("1 - Criar Usuário");
            Console.WriteLine("2 - Listar Usuários");
            Console.WriteLine("3 - Atualizar Usuário");
            Console.WriteLine("4 - Deletar Usuário");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao) {
                case "1": CriarUsuario(); break;
                case "2": ListarUsuarios(); break;
                case "3": AtualizarUsuario(); break;
                case "4": DeletarUsuario(); break;
                case "5": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }
    
    }

    static void CriarUsuario() {
        Console.Write("Digite o nome do usuário: ");
        string nome = Console.ReadLine();
        usuarios.Add(nome);
        Console.WriteLine($"Usuários '{nome}' adicionado com sucesso!");
    }

    static void ListarUsuarios() {
        if (usuarios.Count == 0) {
            Console.WriteLine("Nenhum usuários cadastrado.");
            return;
        }

        Console.WriteLine("\nLista de Usuários:");
        for (int i = 0; i < usuarios.Count; i++) {
            Console.WriteLine($"{i + 1}. {usuarios[i]}");
        }
    }

    static void AtualizarUsuario() {
        ListarUsuarios();
        Console.Write("\nDigite o número do usuários que deseja atualizar: ");
        int index;
        if (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > usuarios.Count) {
            Console.WriteLine("Número inválido!");
            return;
        }

        Console.Write("Digite o novo nome: ");
        string novoNome = Console.ReadLine();
        usuarios[index - 1] = novoNome;
        Console.WriteLine("Usuário atualizado com sucesso!");
    }

    static void DeletarUsuario() {
        ListarUsuarios();
        Console.Write("\nDigite o número do usuário que deseja deletar: ");
        int index;
        if (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > usuarios.Count) {
            Console.WriteLine("Número inválido!");
            return;
        }

        Console.WriteLine($"Usuário '{usuarios[index - 1]}' removido.");
        usuarios.RemoveAt(index - 1);
    }

}