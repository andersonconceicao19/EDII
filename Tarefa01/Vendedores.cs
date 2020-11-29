
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

        public double valorVendas()
        {
            return 1.1;
        }
        public double valorComissao()
        {
            return 1.1;
        }
        public bool addVendedor(Vendedor v)
        {
            if(qtde < 3)           
            {
                for (int i = 0; i < osVendedores.Length; i++)
                {
                    if (osVendedores[i].Id == -1)
                    {
                        osVendedores[i] = v;
                        qtde++;
                        break;
                    }                    
                   
                }
                return true;
            }    
            return false;     
        }

        public bool delVendedor(int id)
        {
            var vendedor = PegarVendedorPorId(id);
            bool deletar = (qtde > 0);

            if (deletar)
            {
                for (int i = 0; i < osVendedores.Length; i++)
                {
                    foreach (var item in vendedor.AsVendas)
                    {
                        if (item.Dia > 0)
                        {
                            return false;
                        }
                        break;
                      
                    }
                }

                for (int i = 0; i < osVendedores.Length; i++)
                {

                    if (osVendedores[i] == vendedor)
                    {
                        vendedor = new Vendedor(-1, "...");
                        osVendedores[i] = vendedor;
                        qtde--;
                        deletar =  true;
                    }
                }               
            }
            return deletar;

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