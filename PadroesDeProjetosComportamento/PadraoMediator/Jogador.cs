using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoMediator
{
    public abstract class Jogador
    {
        protected Mediador mediador;

        public Jogador(Mediador mediador)
        {
            this.mediador = mediador;
        }
    }
}
