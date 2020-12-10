----------------------------------------------
| Data |
|--------------------------------------------|
| - dia: int |
| - mes: int |
| - ano: int |
|--------------------------------------------|
| + setData(int dia, int mes, int ano): void |
| + ToString(): String (override) |
| -> retornando "dd/mm/aaaa" |
----------------------------------------------
-----------------------------------
| Contato |
|---------------------------------|
| - email: string |
| - nome: string |
| - telefone: string |
| - dtNasc: Data |
|---------------------------------|
| + getIdate(): int |
| + ToString(): String (override) |
| -> retornando uma string com |
| todos os dados do contato |
----------------------------------- 

-----------------------------------------
| Contatos |
|---------------------------------------|
| - agenda: List<Contato> (readOnly) |
|---------------------------------------|
| + adicionar(Contato c): bool |
| + pesquisar(Contato c): Contato |
| + alterar(Contato c): bool |
| + remover(Contato c): bool |
| + Equals(object obj): bool (override) |
----------------------------------------


Regras de negócio:
1. O botão “NOVO” só deverá limpar os componentes TextBoxes;
2. O botão “GRAVAR” deverá fazer a adição ou alteração do contato,
baseado na existência prévia (ou não) do elemento na lista;
3. O botão “EXCLUIR” deverá remover o contato da lista, indicando ou
não o sucesso da operação;
4. O botão “PESQUISAR” deverá, utilizando o atributo e-mail como
chave, fazer a pesquisa do contato na lista e preencher os demais
atributos quando o contato for encontrado ou informando, através
de um alerta, a situação de contato não encontrado;
5. O botão “LISTAR” deverá preencher o componente localizado abaixo
dos botões (pode ser um ListBox ou um DataGridView).
** Acabei me esquecendo de, ao criar o formulário acima, de reservar
3 TextBoxes para os atributos dia, mês e ano (relativos à data de
nascimento do contato). Como um erro não justifica o outro, cabe a
vocês garantirem a existência desses componentes!!! 