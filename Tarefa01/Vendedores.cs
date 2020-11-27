
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
            if(qtde < 3)
            {
                osVendedores[qtde] = v;
                qtde++;
                return true;
            }    
            return false;     
        }
        public bool delVendedor(Vendedor v){ 
            return true;
        }
      

        public Vendedor searchVendedor(Vendedor v){ 
            return v;
        }
        public double valorVendas (){
            return 1.1;
        }
        public double valorComissao (){
            return 1.1;
        }
        
        
    }
}