using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_15_12_2020
{
    public class Exemplar
    {
        public Exemplar()
        {
            adicionarExemplar();
            Emprestimos = new List<Emprestimo>();
        }

        public int Tombo { get; private set; } = 0;
        public List<Emprestimo> Emprestimos { get; private set; } 

        public void adicionarExemplar()
        {
            Tombo = Tombo + 1;
        }
        public bool emprestar()
        {
           // Emprestimos.Add();
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
        public override string ToString()
        {
            return $"Tombo = {Tombo}";
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
