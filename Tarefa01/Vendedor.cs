namespace Tarefa01 
{
    public class Vendedor 
    {
        public Vendedor(int id, string nome, double percComissao, Venda[] asVendas)
        {
            Id = id;
            Nome = nome;
            PercComissao = percComissao;
            AsVendas = asVendas;
        }
        public Vendedor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double PercComissao { get; private set; }
        public Venda[] AsVendas { get; private set; }


        public  void  registrarVenda(int dia, Venda venda){

        }
        public double valorVendas(){
            return 1.1;
        }
        public double valorComissao(){
            return 2.2;
        }

    }
}