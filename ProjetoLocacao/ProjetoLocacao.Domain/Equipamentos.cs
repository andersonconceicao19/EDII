using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoLocacao.Domain
{
    class Equipamentos
    {
        private List<Equipamento> equipamentos;

        public Equipamentos(List<Equipamento> equipamentos)
        {
            this.equipamentos = equipamentos;
        }

        public bool Cadastrar(Equipamento equipamento)
        {
            if (equipamentoExiste(equipamento))
            {
                return false;
            }

            equipamentos.Add(equipamento);
            return true;
        }

        public Equipamento Buscar(Equipamento equipamentoProcurado)
        {
            return equipamentos.Where(x => x.Equals(equipamentoProcurado)).SingleOrDefault();
        }

        public void ListarEquipamentos() {
            foreach(var equipamento in equipamentos)
            {
                Console.WriteLine($" ID: { equipamento.Id } - Equipamento: { equipamento.Tipo }");
            }
        }

        private bool equipamentoExiste(Equipamento equipamento)
        {
            if (equipamentos.Where(x => x.Equals(equipamento)).Count() > 0)
                return true;

            return false;
        }
    }
}
