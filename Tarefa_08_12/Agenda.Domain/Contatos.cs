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
            _agenda.Add(new Contato(c.Nome, c.Email, c.Telefone, c.DtNascimento));
            return true;
        }
        public Contato Pesquisar(Contato c)
        {
            var x = findContato(c);
            if (x == -1) return null;
            return _agenda[x];
        }
        public bool Alterar(Contato c)
        {
            var x = findContato(c);
            if (x == -1) return false;
            _agenda[x] = new Contato(c.Nome, c.Email, c.Telefone, c.DtNascimento);
            return true;
        }
        public bool Remover(Contato c)
        {
            var x = findContato(c);
            if (x == -1) return false;
            _agenda.RemoveAt(x);
            return true;
        }
        public List<Contato> getAllContacts()
        {
            return _agenda;
        }
        private int findContato(Contato c)
        {
            return _agenda.FindIndex(0, x => (x.Nome == c.Nome) && (x.Email == c.Email));
        }
        public override bool Equals(object obj)
        {

            return base.Equals(obj);
        }
    }
}
