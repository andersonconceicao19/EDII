using System;
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
            Exemplares = new List<Exemplar>();
        }

        public int ISBN { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }
        public List<Exemplar> Exemplares { get; private set; }


        public void adicionarExemplar()
        {
            Exemplares.Add(new Exemplar());
        }
        /*public int qtdeExemplares()
        {
            
        }*/
        public bool emprestar()
        {
            
            for (int i = 0; i < Exemplares.Count; i++)
            {
               
                if (Exemplares[i].emprestar())
                {
                   return true;
                }
            }
            return false;
        }
        public int qtdeDisponiveis()
        {
            return Exemplares.Count;
        }
        public int qtdeEmprestimos()
        {
            return 1;
        }
        public double percDisponibilidade()
        {
            return 1.1;
        }
        public override string ToString()
        {
            var livro = $" titulo= {this.Titulo}, Autor= {Autor}, Editora={Editora}, ISBN = {ISBN} \n" +
                $"Quantidade de livros disponiveis = {qtdeDisponiveis()}\n" +
                $"Quantidade de emprestimos = { qtdeEmprestimos()} \n" +
                $"Percentual disponibilidade = {percDisponibilidade()} \n" +
                $"{Exemplares}";

            return livro;
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
