/* Você está criando um sistema para agendamento de consultas em uma clínica. Toda consulta envolve o nome do paciente, o nome do médico e a data marcada. É comum que consultas sejam reagendadas — e seu sistema precisa permitir isso.

Você deve criar uma classe que represente uma consulta com os dados essenciais e um método para reagendar, mantendo o controle da data atualizada.

Crie uma classe chamada Consulta com:

Propriedade pública NomePaciente.
Propriedade pública NomeMedico.
Propriedade pública DataConsulta (do tipo DateTime).
Método Reagendar(DateTime novaData) para atualizar a data.
Método ExibirResumo() que mostra as informações da consulta, usando "Data:" na primeira exibição e "Nova data:" se ela tiver sido reagendada.
Exemplo de entrada:

Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
consulta.ExibirResumo();
consulta.Reagendar(new DateTime(2025, 5, 25));
consulta.ExibirResumo();

Exemplo de saída:

Consulta marcada com Dra. Renata para o paciente João Lima.
Data: 20/05/2025

Consulta marcada com Dra. Renata para o paciente João Lima.
Nova data: 25/05/2025 */

Consulta consulta = new Consulta("João Lima", "Dra. Retana", new DateTime(2026, 4, 29));
consulta.ExibirResumo();
consulta.Reagendar(new DateTime(2026, 5, 02));
consulta.ExibirResumo();