/* A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.

Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista. */

using Alura.Filmes;

Filme filme = new Filme("Um sonho de liberdade", 142, new List<string>() { "Tim Robbins", "Morgan Freeman" });
Filme filme2 = new Filme("O poderoso chefão", 175, new List<string>() { "Marlon Brando", "Al Pacino", "Talia Shire" });
Filme filme3 = new Filme("Batman - O Cavaleiro das Trevas", 152, new List<string>() { "Christian Bale", "Heath Ledger", "Maggie Gyleenhaal" });
Filme filme4 = new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<string>() { "Elijah Wood", "Ian McKellen", "Viggo Mortensen" });
Filme filme5 = new Filme("Green Book - O Guia", 130, new List<String>() { "Viggo Mortensen", "Mahershala Ali" });

List<Filme> meusFilmesFavoritos = new List<Filme>();
meusFilmesFavoritos.Add(filme);
meusFilmesFavoritos.Add(filme2);
meusFilmesFavoritos.Add(filme3);
meusFilmesFavoritos.Add(filme4);
meusFilmesFavoritos.Add(filme5);

foreach (Filme f in meusFilmesFavoritos) {
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ListarElenco();
    Console.WriteLine();
}