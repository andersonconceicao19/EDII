using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Atendimento.DLL
{
    public class Guiche
    {
        public Guiche()
        {
            Atendimento = new Queue<Senha>();
        }
        public Guiche(int id)
        {
            Id = id;
            Atendimento = new Queue<Senha>();
        }

        public int Id { get; private set; }
        public Queue<Senha> Atendimento { get; private set; }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            filaSenhas.Dequeue();
            return true;
        }
    }
}
