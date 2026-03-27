/* Você é responsável pelo desenvolvimento do sistema de avaliação de uma escola de tecnologia. 
Seu programa precisa analisar o desempenho dos alunos em cada módulo e atribuir uma classificação que reflita seu aproveitamento.

Crie um sistema que:

Receba a nota final do aluno
Classifique o desempenho conforme a tabela:
A (notas ≥ 9)
B (notas ≥ 7 e < 9)
C (notas ≥ 5 e < 7)
D (notas < 5)
Exiba a classificação obtida.
Exemplo de entrada:

Informe a nota final do aluno:
8,5

Saída esperada:

O aluno recebeu a nota B. */
string note;
Console.Write("Informe a nota final do aluno: ");
decimal finalNote = decimal.Parse(Console.ReadLine());
if (finalNote >= 9) {
    note = "A";
} else if (finalNote >= 7) {
    note = "B";
} else if (finalNote >= 5) {
    note = "C";
} else {
    note = "D";
}

Console.WriteLine($"O aluno recebeu a nota {note}");