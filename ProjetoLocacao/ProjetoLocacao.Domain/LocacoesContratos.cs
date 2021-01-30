using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoLocacao.Domain
{ 
    class LocacoesContratos
    {
        private List<LocacaoContrato> contratos;

        public LocacoesContratos(List<LocacaoContrato> contratos)
        {
            this.contratos = contratos;
        }

        public void Cadastrar(LocacaoContrato contrato)
        {
            if (IdJaCadastrado(contrato))
                throw new Exception("Um equipamento com este Id já foi cadastrado");

            contratos.Add(contrato);

        }

        private bool IdJaCadastrado(LocacaoContrato contrato)
        {
            if (contratos.Where(x => x.Equals(contrato)).Count() > 0)
                return true;

            return false;
        }

        public void ListarContratos()
        {
            foreach (var contrato in contratos)
            {
                contrato.DadosContrato();
            }
        }

        internal List<LocacaoContrato> ListarContratosLiberados()
        {
            return contratos.Where(x => x.Liberar()).ToList();
        }

        internal List<LocacaoContrato> PesquisarComFiltros(LocacaoContrato contrato)
        {
            List<LocacaoContrato> contratosPesquisados = contratos;

            if (contrato.ClienteId != 0)
            {
                contratosPesquisados = contratosPesquisados.Where(x => x.ClienteId.Equals(contrato.ClienteId)).ToList();
            }

            if (contrato.DataEntrada != DateTime.MinValue)
            {
                contratosPesquisados = contratosPesquisados.Where(x => x.DataEntrada.Equals(contrato.DataEntrada)).ToList();
            }

            if (contrato.DataSaida != DateTime.MinValue)
            {
                contratosPesquisados = contratosPesquisados.Where(x => x.DataEntrada.Equals(contrato.DataEntrada)).ToList();
            }

            return contratosPesquisados;
        }

        internal LocacaoContrato Buscar(LocacaoContrato contratoLocacao)
        {
            return contratos.Where(x => x.Equals(contratoLocacao)).FirstOrDefault();
        }
    }
}
