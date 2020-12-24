using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Atendimento.DLL
{
    public class Senhas
    {
        public Senhas()
        {
            Senha = new Queue<Senha>();
        }

        public int ProximoAtendimento { get; private set; }
        public Queue<Senha> Senha { get; private set; }

        public void gerarSenha()
        {
            int idParcial = 0;
            if (Senha.Count != 0)
            {
                idParcial = Senha.Last().Id + 1;
            }
            
           
            this.Senha.Enqueue(new Senha(idParcial));
        }
      
    }
}
