using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_15_12_2020
{
    public class Exemplar
    {
        private static int count = 0;
        public Exemplar()
        {
            adicionarExemplar();
            Emprestimos = new List<Emprestimo>();
            Emprestimos.Add(new Emprestimo());
        }

        public int Tombo { get; private set; }
        public List<Emprestimo> Emprestimos { get; private set; } 

        public bool emprestar()
        {
            for (int i = 0; i < Emprestimos.Count; i++)
            {
                if(!(Emprestimos[i].DtDevolução.Year == 2008))
                {
                    Emprestimos[i].setEmprestimo(DateTime.Now);
                    Emprestimos[i].setDevolucao(new DateTime(2008, 5, 1, 8, 30, 52));
                    return true;
                }                
            }
          
            return false;
        }
        public bool devolver()
        {
            for (int i = 0; i < 1; i++)
            {
                Emprestimos[i].setDevolucao(DateTime.Now);
            }
            
            return true;
        }
        public bool disponivel()
        {
            return true;
        }
        public int qtdeEmprestimo()
        {

            return Emprestimos.Count - Tombo;
        }
        public override string ToString()
        {
            return $"Tombo = {Tombo}";
        }

        private void adicionarExemplar()
        {
            count++;
            Tombo = count;
        }

    }
    /*
    ------------------------------------
    | Exemplar                         | 
    |----------------------------------|
    | - tombo: int                     |
    | - emprestimos: List<Emprestimo>  |
    |----------------------------------|
    | + emprestar(): bool              |
    | + devolver(): bool               |
    | + disponivel(): bool             |
    | + qtdeEmprestimos(): int         |
    ------------------------------------
     */
}
