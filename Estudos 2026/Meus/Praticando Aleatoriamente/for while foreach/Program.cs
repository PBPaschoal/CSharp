Console.Write("Qual tabuada deseja calcular? ");
int valor = int.Parse(Console.ReadLine());
int resultado = 0;
for(int i = 0; i <= 10; i++) {
    resultado = valor * i;
    Console.WriteLine($"{valor} * {i} = {resultado}");
}

string senhaOriginal = "aBc@123";
int tentativas = 5;
while(tentativas != 0) {
    Console.WriteLine("Informe a senha: ");
    string senhaDigitada = Console.ReadLine();
    if(senhaDigitada != senhaOriginal) {
        Console.WriteLine("Senha invalida!");
        tentativas--;
        if(tentativas == 0) {
            Console.WriteLine("Limite de tentativa de acesso atingido.");
        }
    } else {
        tentativas = 0;
        Console.WriteLine("Acesso permitido!");
    }
}

string[] nomes = {"Bruno", "Bruna", "Kabeça", "Lola", "Pepe Antonio", "Jhenna", "Belinha", "Fred", "Pandora", "Simon"};
foreach(string nome in nomes) {
    Console.WriteLine(nome);
}
