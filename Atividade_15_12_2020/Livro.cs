using System;
using System.Collections.Generic;

namespace Atividade_15_12_2020
{
    public class Livro
    {
        private static int countEmprestimo = 0;
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
                   Exemplares[i].disponivel(false);
                   countEmprestimo++;
                   return true;
                }
            }
            return false;
        }
        public bool devolver()
        {
            for (int i = 0; i < Exemplares.Count; i++)
            {

                if (Exemplares[i].devolver())
                {
                    Exemplares[i].disponivel(true);
                    return true;
                }
            }
            return false;
        }
        public int qtdeDisponiveis()
        {
            return Exemplares.Count;
        }
        public double percDisponibilidade()
        {
            int disp = 0;
            for (int i = 0; i < Exemplares.Count; i++)
            {
                if (Exemplares[i].Disponivel)
                {
                    disp++;
                }
               
            }
            
            return (disp / Exemplares.Count * 100);
        }
       
        public string sintetico()
        {
            var livro = $"titulo= {this.Titulo}\n" +
                $"Quantidade de livros disponiveis = { qtdeDisponiveis() }\n" +
                $"Quantidade de emprestimos = { Exemplares[0].qtdeEmprestimo() } \n" +
                $"Percentual disponibilidade = { percDisponibilidade() }% \n";

            return livro;
        }
        public string analitico()
        {
            string emprestmos ="";
            var count = Exemplares.Count;
            for (int i = 0; i < count; i++)

            {
                for (int j = 0; j < Exemplares[i].qtdeEmprestimo(); j++)
                {
                    emprestmos += $" \n \nO {(j+1)}º Emprestimo = { Exemplares[i].Emprestimos[j].DtEmprestimo } \n" +
                     $"A {(j + 1)}º Devolução = {Exemplares[i].Emprestimos[j].DtDevolução}";
                }
             
            }


                var livro = $"titulo= {this.Titulo}, \nAutor= { Autor}, \nEditora={Editora},\nISBN = {ISBN } \n" +
                $"Quantidade de livros disponiveis = { qtdeDisponiveis() }\n" +
                $"Quantidade de emprestimos = { Exemplares[0].qtdeEmprestimo() } \n" +
                $"Percentual disponibilidade = { percDisponibilidade() }% \n" +
                $"Emprestimos: \n {emprestmos}";

            return livro;
        }
    }
}
