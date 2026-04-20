/* Exercício Aula 09 Parte 04: Criar um construtor para a classe Titular, que inicialize todas suas propriedades (na classe Titular)
Criar um construtor para a classe Conta, que inicialize todas suas propriedades (na classe Conta)
Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.
Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.
 */

Titular titular = new Titular("Bruno Paschoal", "000.000.000-00", "Rua do CSharp, Brasil");
Conta c = new Conta(titular, 1, 9292, 999922);

Console.WriteLine(c.Informacoes);