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
        public Vendedor(int id, string nome, double percComissao)
        {
            Id = id;
            Nome = nome;
            PercComissao = percComissao;
            AsVendas = new Venda[3];
            for (int i = 0; i < 3; ++i)
            {
                AsVendas[i] = new Venda(0, 0.0, 0);
            }
        }

        public Vendedor()
        {
            AsVendas = new Venda[3];
            for (int i = 0; i < 3; ++i)
            {
                AsVendas[i] = new Venda(0, 0.0, 0);
            }

        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double PercComissao { get; private set; }
        public Venda[] AsVendas { get; private set; }


    }
}