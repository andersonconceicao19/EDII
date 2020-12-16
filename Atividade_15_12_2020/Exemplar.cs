using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_15_12_2020
{
    public class Exemplar
    {
        public Exemplar(int tombo)
        {
            Tombo = tombo;
            Emprestimos = new List<Emprestimo>();
        }

        public int Tombo { get; private set; }
        public List<Emprestimo> Emprestimos { get; private set; }

        public bool emprestar()
        {
            return true;
        }
        public bool devolver()
        {
            return true;
        }
        public bool disponivel()
        {
            return true;
        }
        public int qtdeEmprestimo()
        {
            return this.Emprestimos.Count;
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
