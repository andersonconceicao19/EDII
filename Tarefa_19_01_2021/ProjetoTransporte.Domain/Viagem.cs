using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte.Domain
{
    public class Viagem
    {
        public int Id { get; set; }
        public Garagem Origem { get; set; }
        public Garagem Destino { get; set; }
        public Veiculo Veiculo { get; set; }
       

    }
}
