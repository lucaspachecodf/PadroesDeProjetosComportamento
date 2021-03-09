using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoState
{
    public class PersonagemA : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new PersonagemB();
        }
    }
}
