/* Você precisa criar um sistema para uma loja de software. Cada produto digital tem um nome, um preço e detalhes técnicos, como o tamanho do arquivo e o sistema operacional compatível. Esses detalhes técnicos podem variar bastante e, por isso, fazem mais sentido em uma estrutura separada — uma classe só para isso.

Crie:

Uma classe InformacaoTecnica com:
Propriedades TamanhoMB e SistemaOperacional.
Uma classe ProdutoDigital com:
Propriedades Nome, Preco e InfoTecnica (do tipo InformacaoTecnica).
Um método ExibirDetalhes() para mostrar tudo na tela.
Exemplo de entrada:

InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
produto.ExibirDetalhes();
Copiar código
Exemplo de saída:

Produto: Photoshop
Preço: R$ 89,99
Tamanho: 1500MB
Compatível com: Windows/Mac */

using System;
using System.Globalization;

InformacaoTecnica infotecnica = new InformacaoTecnica(1500, "Windows / Mac");
ProdutoDigital produtodigital = new ProdutoDigital("Photoshop", 89.99, infotecnica);
produtodigital.ExibirDetalhes();