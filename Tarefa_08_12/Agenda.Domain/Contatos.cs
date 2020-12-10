using System.Collections.Generic;

namespace Agenda.Domain
{
    public class Contatos
    {
        private readonly List<Contato> _agenda;

        public Contatos()
        {
            _agenda = new List<Contato>();
        }

        public bool Adicionar(Contato c)
        {
            return true;
        }
        public Contato Pesquisar(Contato c)
        {
            return c;
        }
        public bool Alterar(Contato c)
        {
            return true;
        }
        public bool Remover(Contato c)
        {
            return true;
        }
        public override bool Equals(object obj)
        {
            return _agenda.
        }
    }
}
