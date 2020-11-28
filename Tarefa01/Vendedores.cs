
using System.Linq;

namespace Tarefa01
{
    public class Vendedores 
    {

        private Vendedor[] osVendedores;
        private int max = 3;
        private int qtde = 0;


        public Vendedores()
        {
            osVendedores = new Vendedor[max];
            for (int i = 0; i < max; ++i)
            {
                osVendedores[i] = new Vendedor(-1, "...");
            }
        }

        public bool addVendedor(Vendedor v)
        {
            if(qtde < 3)            {
                osVendedores[qtde] = v;
                qtde++;
                return true;
            }    
            return false;     
        }
        public bool delVendedor(Vendedor v){ 
            return true;
        }
      

        public Vendedor searchVendedor(int id)
        {         
            return PegarVendedorPorId(id);
        }

        public void registrarVenda(int id, Venda venda)
        {
            var vendedor = PegarVendedorPorId(id);


            for (int i = 0; i < vendedor.AsVendas.Length; i++)
            {
                if (vendedor.AsVendas[i].Dia == 0)
                {
                    vendedor.AsVendas[i] = venda;
                    break;
                }
            }
            
        }

        public double valorVendas (){
            return 1.1;
        }
        public double valorComissao (){
            return 1.1;
        }    
        private Vendedor PegarVendedorPorId(int id)
        {
            foreach (var item in osVendedores)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        
    }
}