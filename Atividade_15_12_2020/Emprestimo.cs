using System;

namespace Atividade_15_12_2020
{
    public class Emprestimo
    {
        public Emprestimo()
        {
            DtEmprestimo = DateTime.Now;
            DtDevolução = DateTime.Now;

        }
       
        public DateTime DtEmprestimo { get; private set; }
        public DateTime DtDevolução { get; private set; }

        public DateTime setEmprestimo(DateTime dateTime)
        {
            return (DtEmprestimo = dateTime);
        }
        public DateTime setDevolucao(DateTime dateTime)
        {
           return (DtDevolução = dateTime);
        }
    }
    /*
        ------------------------------
        | Emprestimo                 |
        |----------------------------|
        | - dtEmprestimo: DateTime   |
        | - dtDevolucao: DateTime    |
        ------------------------------
     */
}
