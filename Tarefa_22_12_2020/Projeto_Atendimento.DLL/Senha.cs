using System;

namespace Projeto_Atendimento.DLL
{
    public class Senha
    {
        public Senha(int id)
        {
            Id = id;
            DataGeracao = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            HoraGeracao = DateTime.Now;
        }

        public int Id { get; private set; }
        public DateTime DataGeracao { get; private set; }
        public DateTime HoraGeracao { get; private set; }
        public DateTime DataAtendimento { get; private set; }
        public DateTime HoraAtendimento { get; private set; }

        public string dadosParciais()
        {
            return $"{ this.Id } - { this.DataGeracao.Date.ToString().Substring(0, 10) } - { this.HoraGeracao.TimeOfDay.ToString().Substring(0, 8) }";
        }
        public string dadosCompletos()
        {
            return $"{ this.Id } - { this.DataGeracao } - { this.HoraGeracao} - {this.DataAtendimento} - { this.HoraAtendimento }";
        }
    }
}
