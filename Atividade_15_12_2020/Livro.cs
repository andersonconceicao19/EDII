using System.Collections.Generic;

namespace Atividade_15_12_2020
{
    public class Livro
    {
        public Livro()
        {

        }
        public Livro(int iSBN, string titulo, string autor, string editora)
        {
            ISBN = iSBN;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
        }

        public int ISBN { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }
  

        public void adicionarExemplar(int qtd)
        {
            new Exemplar(qtd);
        }
        /*public int qtdeExemplares()
        {
            
        }*/
        public int qtdeDisponiveis()
        {
            return 1;
        }
        public int qtdeEmprestimos()
        {
            return 1;
        }
        public double percDisponibilidade()
        {
            return 1.1;
        }
    }
    /*
     - isbn: int                                   |
    | - titulo: string                             |
    | - autor: string                              |
    | - editora: string                            |
    | - exemplares: List<Exemplar>                 |
    |----------------------------------------------|
    | + adicionarExemplar(Exemplar exemplar): void |
    | + qtdeExemplares(): int                      |
    | + qtdeDisponiveis(): int                     |
    | + qtdeEmprestimos(): int                     |
    | + percDisponibilidade(): double
     */
}
