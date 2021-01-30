using System;
using System.Collections.Generic;


namespace ProjetoLocacao.Domain
{
    class LocacaoContrato 
    {
        public LocacaoContrato()
        {
            Id = 0;
            ClienteId = 0;
            DataSaida = new DateTime();
            DataEntrada = new DateTime();
            Relacoes = new List<Relacao>();
            ItensDisponiveis = new Stack<Item>();
        }
        public LocacaoContrato(int id, 
            int clienteId,
            DateTime dataSaida, 
            DateTime dataEntrada
            )
        {
            Id = id;
            ClienteId = clienteId;
            DataSaida = dataSaida;
            DataEntrada = dataEntrada;
            Relacoes = new List<Relacao>();
            ItensDisponiveis = new Stack<Item>();
        }

        public int Id { get; private set; }
        public int ClienteId { get; private set; }
        public DateTime DataSaida { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public List<Relacao> Relacoes { get; private set; }
        public Stack<Item> ItensDisponiveis { get; private set; }

        public bool Liberar()
        {
            return (ItensDisponiveis.Count > 0 ? true : false);
        }

        public void LiberarItens(List<Item> itens)
        {
            foreach (var item in itens)
            {
                ItensDisponiveis.Push(item);
            }
        }

        public void DadosContrato()
        {
            Console.WriteLine($"Id cliente: { ClienteId }-  Data Entrada: { DataEntrada.ToShortDateString() } | Data Saída: { DataSaida.ToShortDateString() }");

            foreach (var relacao in Relacoes)
            {
                relacao.DadosRelacao();
            }

            //Stack<Item> itensDisponibilizadosAux = itensDisponibilizados;

            foreach (var itens in ItensDisponiveis)
            {
                itens.DadosItens();
            }
        }

        

        internal void DevolverItens(Equipamentos equipamentos)
        {

            while (ItensDisponiveis.Count > 0)
            {
                Item item = ItensDisponiveis.Pop();
                Equipamento equipamento = equipamentos.Buscar(item.Equipamento);
                equipamento.ResgatarItens(item);
            }
        }

        public void DisponibilizarItens(Equipamentos equipamentos)
        {
            foreach (var relacao in Relacoes)
            {
                Equipamento equipamento = equipamentos.Buscar(relacao.Equipamento);

                for (int i = 0; i < relacao.Quantidade; i++)
                {
                    ItensDisponiveis.Push(equipamento.LiberarItens());
                }

            }
        }
        public override bool Equals(object obj)
        {
            var contrato = obj as LocacaoContrato;

            if (contrato.Id == Id)
            {
                return true;
            }

            return false;
        }
    }
}
