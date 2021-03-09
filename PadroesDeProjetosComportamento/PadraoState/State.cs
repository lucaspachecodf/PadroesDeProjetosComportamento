using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoState
{
    public abstract class State
    {
        public abstract void Acao(Contexto contexto);
    }
}
