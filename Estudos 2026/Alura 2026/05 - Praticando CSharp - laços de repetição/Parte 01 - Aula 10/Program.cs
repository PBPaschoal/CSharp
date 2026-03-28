/* Imagine que você está desenvolvendo um sistema de chamada escolar para uma instituição de ensino. 
A pessoa responsável precisa verificar rapidamente se um aluno específico está presente na lista de chamada. 
Seu programa deve percorrer a lista de nomes e, ao encontrar o aluno procurado, interromper imediatamente.

Crie um programa que:

    Defina uma lista de nomes dos alunos.
    Utilize um loop para percorrer a lista.
    Interrompa a busca quando o nome desejado for encontrado.
    Informe se o nome não for encontrado.

Exemplo de entrada: Para a seguinte lista de nomes: { "Ana", "Carlos", "Bianca", "João", "Marina" }.

Digite o nome do aluno:
João

Saída esperada (caso encontre):

Aluno encontrado na posição: 3

Saída esperada (caso não encontre):

Aluno não está presente na lista */

List<string> alunos = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };
 
Console.WriteLine("Digite o nome do aluno:");
string nomeBusca = Console.ReadLine();
int indice = 0;
bool encontrado = false;
 
while (indice < alunos.Count) {
    if (alunos[indice] == nomeBusca) {
        encontrado = true;
        break;  
    }
    indice++; 
}
 
if (encontrado) {
    Console.WriteLine($"Aluno encontrado na posição: {indice}");
} else {
    Console.WriteLine("Aluno não está presente na lista");
}
