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
            Disponivel = true;
        }

        public int Tombo { get; private set; }
        public List<Emprestimo> Emprestimos { get; private set; }
        public bool Disponivel { get; private set; }

        public bool emprestar()
        {
            for (int i = 0; i < Emprestimos.Count; i++)
            {
                if(Disponivel)
                {
                    Emprestimos.Add(new Emprestimo(DateTime.Now, null));
                    return true;
                }                
            }
          
            return false;
        }
        public bool devolver()
        {
            for (int i = 0; i < Emprestimos.Count; i++)
            {
                if (!Disponivel)
                {
                    Emprestimos[i].setDevolucao(DateTime.Now);
                    return true;
                }
            }

            return false;
        }
        public bool disponivel(bool element)
        {
            Disponivel = element;
            return Disponivel;
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
