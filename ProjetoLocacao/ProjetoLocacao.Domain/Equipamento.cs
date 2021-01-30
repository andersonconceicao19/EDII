using System;
using System.Collections.Generic;


namespace ProjetoLocacao.Domain
{
    class Equipamento
    {
        public int Id { get; private set; }
        public string Tipo { get; private set; }
        public double ValorDiaria { get; private set; }
        public Queue<Item> Items { get; private set; }
       

        public Equipamento(int id, 
                           double valorDiaria, 
                           string tipo,
                           Queue<Item> itens)
        {
            Id = id;
            Tipo = tipo;
            ValorDiaria = valorDiaria;
            Items = itens;
        }

        public void CadastrarItem(Item item)
        {
            foreach(var i in Items)
            {
                if (i.Equals(item))
                    throw new Exception($"Um item já foi cadastrado com o patrimônio {item.Patrimonio}. Insira um patrimônio diferente");
            }

            Items.Enqueue(item);

            Console.Clear();
            Console.WriteLine("\n Item Cadastrado com sucesso");
        }

        public Item LiberarItens()
        {
            return Items.Dequeue();
        }

        public void ResgatarItens(Item item)
        {
            Items.Enqueue(item);
        }

        public void ListarItens()
        {
            if (Items.Count > 0)
            {
                Console.Clear();
                Console.WriteLine($" Itens do equipamento {Tipo}");

                foreach (var item in Items)
                {
                    Console.WriteLine($"\n Patrimônio: {item.Patrimonio} | Avaria: {(item.Avarias ? "Sim" : "Não")}");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\n Não há itens cadastrados para este equipamento");
            }
        }

        public override bool Equals(object obj)
        {
            var equipamento = obj as Equipamento;

            if (equipamento.Id == Id)
            {
                return true;
            }

            return false;
        }
    }
}
