using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoChainOfResponsability
{
    public abstract class Manipulador
    {
        protected Manipulador sucessor;

        public void defineSucessor(Manipulador sucessor)
        {
            this.sucessor = sucessor;
        }

        public abstract void Convoca(int quantidadePoder);
    }
}
