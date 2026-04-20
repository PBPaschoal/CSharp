/* No C#, uma função lambda pode ser aplicada em atributos, propriedades ou na forma como escrevemos funções. 
Abaixo, existe uma função que soma 2 valores inteiros e retorna o resultado da soma, como mostra o trecho de código a seguir:

public int Somar(int a, int b)
{
    int resultado = a + b;
    return resultado;
}
Agora é sua vez! Refaça esse método Somar() usando uma função lambda retornando o resultado da operação. */

Somando programa = new Somando();

int resultado = programa.Somar(3, 2);
Console.WriteLine(resultado);

