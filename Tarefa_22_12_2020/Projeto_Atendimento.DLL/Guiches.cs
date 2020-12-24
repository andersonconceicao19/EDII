using System.Collections.Generic;

namespace Projeto_Atendimento.DLL
{
    public class Guiches
    {
        public Guiches()
        {
            GuicheLista = new List<Guiche>();
        }
        public List<Guiche> GuicheLista { get; private set; }
        public void adicionar(Guiche guiche)
        {
            if (GuicheLista.Count == 0)
            {
                GuicheLista.Add(new Guiche());
            }
            else
            {
                GuicheLista.Add(new Guiche( (GuicheLista.Count +1) ));
            }
        }
    }
}
