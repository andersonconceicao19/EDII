using System;

namespace ProjetoLocacao.Domain
{
    
    class Relacao
    {
        public int Quantidade { get; private set; }
        public Equipamento Equipamento { get; private set; }
        
        public Relacao(Equipamento tipo, int quantidade)
        {
            Equipamento = tipo;
           Quantidade = quantidade;
        }

        public void DadosRelacao()
        {
            Console.WriteLine($" Tipo: { Equipamento.Tipo } | Quantidade: { Quantidade }");
        }
    }
}
