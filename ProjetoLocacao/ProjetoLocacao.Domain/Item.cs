using System;


namespace ProjetoLocacao.Domain { 
    class Item
    {
        public Equipamento Equipamento { get; private set; }
        public int Patrimonio { get; private set; }
        public bool Avarias { get; private set; }
     

        public Item(Equipamento equipamento, int patrimonio, bool avaria)
        {
            Equipamento = equipamento;
            Patrimonio = patrimonio;
           Avarias = avaria;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Item;

            if (item.Patrimonio.Equals(Patrimonio))
            {
                return true;
            }

            return false;
        }

        internal void DadosItens()
        {
            Console.WriteLine($" Tipo: { Equipamento.Tipo } - Patrimônio: { Patrimonio } | Avariado: { (Avarias ? "sim" : "nao") }");
        }
    }
}
