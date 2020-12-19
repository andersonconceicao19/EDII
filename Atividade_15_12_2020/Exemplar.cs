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
           
        }

        public int Tombo { get; private set; }
        public List<Emprestimo> Emprestimos { get; private set; }
        public bool Disponivel { get; private set; }

        public bool emprestar()
        {
         //   Emprestimos.Add(new Emprestimo());
             if(Emprestimos.Count == 0)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        if (Disponivel)
                        {
                            Emprestimos.Add(new Emprestimo(DateTime.Now, null));
                            
                            return true;
                        }
                    }
               
                }
            else
            {
            
                for (int i = 0; i < Emprestimos.Count; i++)
                {
                    if(Disponivel)
                    {
                        Emprestimos.Add(new Emprestimo(DateTime.Now, null));
                        return true;
                    }                
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
            return Emprestimos.Count;
        }
        private void adicionarExemplar()
        {
            Emprestimos = new List<Emprestimo>();
            Disponivel = true;
            count++;
            Tombo = count;
        }
       
        
    }
   
}
