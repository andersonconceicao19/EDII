using System;

namespace Projeto_Atendimento.DLL
{
    public class Senha
    {
        public Senha(int id)
        {
            Id = id;
            DataGeracao = DateTime.Today;
            //HoraGeracao = DateTime.Today
        }

        public int Id { get; private set; }
        public DateTime DataGeracao { get; private set; }
        public DateTime HoraGeracao { get; private set; }
        public DateTime DataAtendimento { get; private set; }
        public DateTime HoraAtendimento { get; private set; }

        public string dadosParciais()
        {
            return $"{ this.Id } + ”-“ + ${ this.DataGeracao } + ”-“ + ${ this.HoraGeracao}";
        }
        public string dadosCompletos()
        {
            return $"{ this.Id } - { this.DataGeracao } - { this.HoraGeracao} - {this.DataAtendimento} - { this.HoraAtendimento }";
        }
    }
}
