/* Imagine que você está criando um sistema de recomendação para uma plataforma de filmes. Cada filme tem um título e uma classificação indicativa. Para garantir que as pessoas vejam apenas conteúdos apropriados para sua idade, o sistema deve verificar se a pessoa pode assistir ao filme com base na idade informada.

Crie uma classe chamada Filme que tenha:

Propriedades públicas Titulo e ClassificacaoEtaria (int).
Um método chamado PodeAssistir(int idadeUsuario) que retorna true se a idade for maior ou igual à classificação etária, e false caso contrário.
Um método ExibirResultado(int idadeUsuario) que exiba uma mensagem amigável informando se o usuário pode ou não assistir ao filme.
Exemplo de entrada:

Filme filme = new Filme("Matrix", 16);
filme.ExibirResultado(14);
filme.ExibirResultado(20);

Exemplo de saída:

Usuário com 14 anos não pode assistir ao filme Matrix.
Usuário com 20 anos pode assistir ao filme Matrix.*/

Filme filme = new Filme("Matrix", 16);
filme.ExibirResultado(14);
filme.ExibirResultado(20);