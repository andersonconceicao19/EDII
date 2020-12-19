using System;

namespace Atividade_15_12_2020
{
    public class Emprestimo
    {
        public Emprestimo()
        {
            DtEmprestimo = null;
            DtDevolução = null;

        }

        public Emprestimo(DateTime? dtEmprestimo, DateTime? dtDevolução)
        {
            DtEmprestimo = dtEmprestimo;
            DtDevolução = dtDevolução;
            
        }

        public DateTime? DtEmprestimo { get; private set; }
        public DateTime? DtDevolução { get; private set; }

        public void setEmprestimo(DateTime? dateTime)
        {
            DtEmprestimo = dateTime;
        }
        public void setDevolucao(DateTime? dateTime)
        {
           DtDevolução = dateTime;
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
