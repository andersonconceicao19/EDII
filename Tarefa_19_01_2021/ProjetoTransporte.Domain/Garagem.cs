using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte.Domain
{
    public class Garagem
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public Stack<Veiculo> Veiculos { get; set; }
        
        public int qtdeDeVeiculos()
        {
            return 1;
        }
        public int potencialDeTransporte()
        {
            return 1;
        }

    }
}
