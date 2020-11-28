namespace Tarefa01 
{
    public class Venda 
    {
        public Venda(int quantidade, double valor, int dia)
        {
            Quantidade = quantidade;
            Valor = valor;
            Dia = dia;
        }
        public int Dia { get; private set; }

        public int Quantidade { get; private set;}
        public double Valor { get; private set;}


        public double ValorMedio()
        {
            return (Valor / Quantidade);
        }
    }
}