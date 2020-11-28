namespace Tarefa01 
{
    public class Venda 
    {
        public Venda(int quantidade, double valor)
        {
            Quantidade = quantidade;
            Valor = valor;
        }

        public int Quantidade { get; private set;}
        public double Valor { get; private set;}


        public double ValorMedio()
        {
            return (Valor / Quantidade);
        }
    }
}