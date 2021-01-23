using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte.Domain
{
    public class Viagens
    {
        public Queue<Viagem> ViagensQueue { get; set; }
        
        public void incluir(Viagem viagem)
        {
            ViagensQueue.Enqueue(viagem);
        }
    }
}
