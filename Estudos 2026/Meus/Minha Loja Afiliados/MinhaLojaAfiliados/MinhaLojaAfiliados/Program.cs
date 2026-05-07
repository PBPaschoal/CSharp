using System;
using System.Collections.Generic;

namespace MinhaLojaAfiliados;
internal class Program {
    public static void Main(string[] args) {
        Produto produtos = new Produto();
        Console.WriteLine("Informe os dados abaixo:\nID DO PRODUTO; NOME DO PRODUTO; MARCA DO PRODUTO; DESCRIÇÃO DO PRODUTO; PLATAFORMA; CATEGORIA; LINK; URL DA IMAGEM");

        produtos.Cadastrar();
        produtos.Exibir();
    }

}