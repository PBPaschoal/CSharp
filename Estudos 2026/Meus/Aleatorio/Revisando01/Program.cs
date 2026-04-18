using System.Globalization;
Console.WriteLine("---------------------------------------");
Console.WriteLine("Revisando algumas coisas sem consultas!");
Console.WriteLine("---------------------------------------");

Console.WriteLine("Vamos contar até que número? ");
int ateQuanto = int.Parse(Console.ReadLine());
Console.WriteLine($"\nContando até {ateQuanto}:");
for(int i = 0; i <= ateQuanto; i++){
    Console.WriteLine(i);
}

Console.WriteLine("\n------------------------");
Console.Write("Informe o seu nome: ");
string nome = Console.ReadLine();
Console.Write("Informe a sua idade: ");
byte idade = Byte.Parse(Console.ReadLine());
Console.Write("Informe o seu sexo: ");
char sexo = Char.Parse(Console.ReadLine());
Console.Write("Informe a sua altura: ");
double altura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
string frase;
if(sexo == 'F' || sexo == 'f') {
    frase = "uma mulher";
} else {
    frase = "um homem";
}
string frase2;
if(altura >= 1.90) {
    frase2 = "muito alta";
}   else if(altura >= 1.70) {
        frase2 = "alta";
    } else {
        frase2 = "baixa";
    }

Console.WriteLine($"Olá {nome}!\nObrigado pelas informações.\nVerifiquei que você é {frase} e tem {idade} anos. E pela a sua altura, você é uma pessoa {frase2}.");