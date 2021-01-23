using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte.Domain
{
    public class Veiculos
    {
        public List<Veiculo> VeiculosList { get; set; }
        
        public bool incluir(Veiculo veiculo)
        {            
            VeiculosList.Add(veiculo);
            return true;
        }
    }
}
