/* Você está desenvolvendo um sistema de gestão de pessoas para uma empresa. O sistema precisa cadastrar funcionários informando o nome e o cargo no momento da criação. E, ele deve permitir que um funcionário seja promovido para um novo cargo, mas apenas se o novo cargo for diferente do atual — não faria sentido uma promoção que não mudasse o cargo da pessoa, concorda?!

Crie uma classe chamada Funcionario que tenha:

Uma propriedade pública Nome.
Uma propriedade pública Cargo.
Um construtor que receba nome e cargo como parâmetros obrigatórios.
Um método chamado Promover(string novoCargo) que atualize o cargo do funcionário, somente se o novo cargo for diferente do atual. Se for o mesmo, exiba uma mensagem de erro informando que a promoção não pode ocorrer.
Depois, crie uma instância da classe, exiba os dados iniciais, promova o funcionário e exiba os dados atualizados.

Exemplo de entrada:

Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");
funcionario.Promover("Assistente Administrativo"); // Tentativa inválida
funcionario.Promover("Analista de Projetos");       // Promoção válida

Exemplo de saída:

Funcionário: Carlos Pereira
Cargo Atual: Assistente Administrativo
 
Erro: O novo cargo deve ser diferente do cargo atual.
 
Promoção realizada com sucesso!
 
--- Após promoção ---
Funcionário: Carlos Pereira
Cargo Atual: Analista de Projetos */

Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");

Console.WriteLine("Funcionário: " + funcionario.Nome);
Console.WriteLine("Cargo Atual: " + funcionario.Cargo);

funcionario.Promover("Assistente Administrativo"); // Tentativa inválida
funcionario.Promover("Analista de Projetos");       // Promoção válida

Console.WriteLine("\n--- Após promoção ---");
Console.WriteLine("Funcionário: " + funcionario.Nome);
Console.WriteLine("Cargo Atual: " + funcionario.Cargo);