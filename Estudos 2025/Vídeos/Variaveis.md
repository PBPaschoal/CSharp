# O que são variáveis?

São espaços de armazenamento na memória do computador que contêm valores.

Podem ser utilizadas para armazenar diferentes tipos de dados, como números, texto, caracteres, entre outros.

## Para que servem as variáveis?

As variáveis são úteis para armazenar informações temporárias ou permanentes durante a execução de um programa.
Permitem manipular e processar dados de forma dinâmica.

### Tipos de variáveis:

- **int (número inteiro):** Utilizado para armazenar números inteiros.
- **double (número decimal):** Usado para armazenar números decimais.
- **String (texto):** Serve para armazenar sequências de caracteres, como palavras ou frase.
- **char (caractere):** Representa um único caractere, como uma letra ou símbolo.
- **boolean (booleano):** Armazena valores lógicos verdadeiro ou falso.

### Nomes de variáveis:

**Não pode começar com dígito:** use uma letra ou _

**Não pode ter espaço em branco**

**Não pode usar acentos ou til**

**Sugestão:** use o padrão “**camel case**”

---

**Errado:**

int 5minutos;

int salário;

int salário do funcionário;

---

**Correto:**

int _5minutos;

int salario;

int salarioDoFuncionario;

---

### System.Globalization

O System.Globalization é um namespace no .NET Framework que fornece classes e tipos relacionados à cultura e à formatação de dados.
Ele contém tipos como CultureInfo, que é usado para trabalhar com informações de cultura e formatação de dados.
Ao usar CultureInfo.InvariantCulture, garantimos que os valores decimais sejam formatados corretamente, independentemente da configuração de cultura do sistema.

#### CultureInfo.InvariantCulture:

No .NET Framework, ao converter valores decimais em strings, o ponto (.) é utilizado como separador decimal padrão.
Isso pode causar inconsistências na formatação de dados em sistemas que esperam a vírgula (,) como separador decimal.
Para garantir a consistência na formatação, podemos utilizar o CultureInfo.InvariantCulture.
CultureInfo.InvariantCulture representa uma cultura invariante, ou seja, uma cultura que não é associada a nenhum país ou região específica.

#### Ponto (.) e Vírgula (,) para Valores Decimais:

Em muitos países, o ponto (.) é utilizado como separador decimal, enquanto em outros, como a maioria dos países europeus, a vírgula (,) é utilizada.
Por exemplo, o número 3.14 representa "três inteiros e quatorze centésimos" nos Estados Unidos, enquanto na maioria dos países europeus, isso seria representado como 3,14.