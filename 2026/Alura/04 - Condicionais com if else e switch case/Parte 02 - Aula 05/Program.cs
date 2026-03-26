/* Você é responsável pelo sistema de catalogação de uma biblioteca universitária. 
Atualmente, os livros são classificados em categorias com base em seus códigos numéricos, mas o código está extenso e difícil de manter devido ao uso excessivo de condicionais if/else.

Atualmente, os livros são organizados em códigos de três dígitos e catalogados de acordo com o número inicial em seu código, seguindo a tabela abaixo:

1: Ficção Científica
2: Literatura Clássica
3: Fantasia
4: Romance
5: Suspense/Mistério
6: Não ficção
7: Biografias/Memórias
8: Distopia
9: Infantojuvenil
Então, um livro com o código 451 seria catalogado como “Romance”, enquanto o livro com o código 762 seria “Biografias/Memórias”. 
Sua tarefa é refatorar o código atual para utilizar switch/case.

Código atual:

Console.WriteLine("Digite o código do livro: ");
int codigo = int.Parse(Console.ReadLine());
 
if (codigo >= 100 && codigo <= 199)
{
    Console.WriteLine("Ficção Científica");
}
else if (codigo >= 200 && codigo <= 299)
{
    Console.WriteLine("Literatura Clássica");
}
else if (codigo >= 300 && codigo <= 399)
{
    Console.WriteLine("Fantasia");
}
else if (codigo >= 400 && codigo <= 499)
{
    Console.WriteLine("Romance");
}
else if (codigo >= 500 && codigo <= 599)
{
    Console.WriteLine("Suspense/Mistério");
}
else if (codigo >= 600 && codigo <= 699)
{
    Console.WriteLine("Não Ficção");
}
else if (codigo >= 700 && codigo <= 799)
{
    Console.WriteLine("Biografias/Memórias");
}
else if (codigo >= 800 && codigo <= 899)
{
    Console.WriteLine("Distopia");
}
else if (codigo >= 900 && codigo <= 999)
{
    Console.WriteLine("Infantojuvenil");
}
else
{
    Console.WriteLine("Código inexistente");
}

Exemplo de entrada:
Digite o código do livro:
142

Saída esperada:
Ficção Científica */

Console.WriteLine("Digite o código do livro:");
int codigo = int.Parse(Console.ReadLine());

switch(codigo / 100) {
    case 1:
        Console.WriteLine("Ficção Científica");
        break;
    case 2:
        Console.WriteLine("Literatura Clássica");
        break;
    case 3:
        Console.WriteLine("Fantasia");
        break;
    case 4:
        Console.WriteLine("Romance");
        break;
    case 5:
        Console.WriteLine("Suspense/Mistério");
        break;
    case 6:
        Console.WriteLine("Não ficção");
        break;
    case 7:
        Console.WriteLine("Biografias/Memórias");
        break;
    case 8:
        Console.WriteLine("Distopia");
        break;
    case 9:
        Console.WriteLine("Infantojuvenil");
        break;
    default:
        Console.WriteLine("Código inexistente!");
        break;
}