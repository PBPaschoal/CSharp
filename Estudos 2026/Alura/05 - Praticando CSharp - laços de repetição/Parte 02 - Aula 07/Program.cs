/* Imagine que você é responsável pelo sistema de monitoramento das notas dos alunos de uma escola. 
Cada aluno tem sua nota monitorada e é importante verificar se algum aluno está com a nota abaixo da média de aprovação. 
Caso a nota de algum aluno esteja abaixo da média, você precisa gerar um alerta. 
O alerta de aprovação é uma média de 7.0, ou seja, qualquer aluno com nota abaixo disso deve gerar um aviso.

Seu desafio é escolher o laço de repetição mais adequado para percorrer a lista de alunos e verificar se as notas deles estão 
dentro da faixa de aprovação.

List<double> notas= new List<double>
        {
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
        };

Saída esperada:

O aluno com a nota 8,5 está indo muito bem!
O aluno com a nota 6,2 está abaixo da média!
O aluno com a nota 9,1 está indo muito bem!
O aluno com a nota 5,8 está abaixo da média!
O aluno com a nota 7,4 está indo muito bem!

E aí? Como você resolveria esse problema? Qual tipo de laço de repetição você usaria para percorrer a lista de alunos? 
Justifique sua escolha e faça o código de resolução, explicando os motivos de usar o laço escolhido no contexto desse problema. */

// Primeira versão:
List<double> notas= new List<double> {8.5, 6.2, 9.1, 5.8, 7.4};

foreach(double nota in notas) {
    if(nota >= 7.0) {
        Console.WriteLine($"O aluno com a nota {nota.ToString("F1")} está indo muito bem!");
    } else {
        Console.WriteLine($"O aluno com a nota {nota.ToString("F1")} está abaixo da média!");
    }
}

// Segunda versão:
List<double> notas2 = new List<double> {
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
};
 
double mediaCorte = 7.0;
 
foreach (var nota2 in notas2) {
    if (nota2 < mediaCorte) {
        Console.WriteLine($"O aluno com a nota {nota2} está abaixo da média!");
    }
 
    else {
        Console.WriteLine($"O aluno com a nota {nota2} está indo muito bem!");
    }
}

