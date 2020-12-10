using Agenda.Domain;
using System;

namespace AgendaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Contatos contatos = new Contatos();
            contatos.Adicionar(new Contato("Anderson", "email@anderson.com", "13996969696", new Data(19, 07, 1994)));
            contatos.Adicionar(new Contato("Silva", "email@anderson.com", "13996969696", new Data(19, 07, 1994)));
            contatos.Adicionar(new Contato("Conceicao", "email@anderson.com", "13996969696", new Data(19, 07, 1994)));

            contatos.Remover(new Contato("Sibraslva", "email@anderson.com", "13996969696", new Data(19, 07, 1994)));
            contatos.Adicionar(new Contato("Silva", "email@anderson.com", "13996969696", new Data(19, 07, 1994)));

            // Console.WriteLine(contatos.Pesquisar(new Contato("Anderson", "email@anderson.com", "13996969696", new Data(19, 07, 1994))));

            foreach (var item in contatos.getAllContacts())
            {
                Console.WriteLine(item);
            }

        }
    }
}
