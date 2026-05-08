using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace MinhaLojaAfiliados;
internal class Program {
    public static void Main(string[] args) {
        List<Produto> listaDeProdutos = new List<Produto>();
        string continuar = "s"; // String para podermos usar ToLower

        while (continuar.ToLower() == "s") {
            Console.WriteLine("\n/// CADASTRAR NOVO PRODUTO ///");
            Console.Write("ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Descrição do produto: ");
            string descricao = Console.ReadLine();
            Console.Write("Plataforma Afiliado: ");
            string plataforma = Console.ReadLine();
            Console.Write("Qual categoria pertence? ");
            string categoria = Console.ReadLine();
            Console.Write("Link para compra: ");
            string link = Console.ReadLine();
            Console.Write("Link da imagem do produto: ");
            string imagemurl = Console.ReadLine();

            Produto produtos = new Produto(id, nome, marca, modelo, descricao, plataforma, categoria, link, imagemurl);
            listaDeProdutos.Add(produtos);

            Console.WriteLine("Deseja adicionar um novo produto? (S/N)");
            continuar = Console.ReadLine();
        }
        Console.WriteLine("-----------------------");
        Console.WriteLine("\nPRODUTOS CADASTRADOS:");
        foreach(var produto in listaDeProdutos) {
            Console.WriteLine();
            produto.Exibir();
        }

        Console.WriteLine("\n/// SISTEMA DE BUSCA ///");
        Console.Write("Digite o nome ou categoria do produto que deseja buscar: ");
        string busca = Console.ReadLine().ToLower();
        Console.WriteLine($"\nResultados para {busca}:\n");
        bool encontrado = false;

        foreach (var produto in listaDeProdutos) {
            if (produto.Nome.ToLower().Contains(busca) || produto.Categoria.ToLower().Contains(busca)) {
                produto.Exibir();
                encontrado = true;
            }
      
        }

        if (!encontrado) {
            Console.WriteLine("Nenhum produto encontrado com esse termos");
        }

    }

}