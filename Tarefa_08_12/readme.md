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


Regras de neg�cio:
1. O bot�o �NOVO� s� dever� limpar os componentes TextBoxes;
2. O bot�o �GRAVAR� dever� fazer a adi��o ou altera��o do contato,
baseado na exist�ncia pr�via (ou n�o) do elemento na lista;
3. O bot�o �EXCLUIR� dever� remover o contato da lista, indicando ou
n�o o sucesso da opera��o;
4. O bot�o �PESQUISAR� dever�, utilizando o atributo e-mail como
chave, fazer a pesquisa do contato na lista e preencher os demais
atributos quando o contato for encontrado ou informando, atrav�s
de um alerta, a situa��o de contato n�o encontrado;
5. O bot�o �LISTAR� dever� preencher o componente localizado abaixo
dos bot�es (pode ser um ListBox ou um DataGridView).
** Acabei me esquecendo de, ao criar o formul�rio acima, de reservar
3 TextBoxes para os atributos dia, m�s e ano (relativos � data de
nascimento do contato). Como um erro n�o justifica o outro, cabe a
voc�s garantirem a exist�ncia desses componentes!!! 