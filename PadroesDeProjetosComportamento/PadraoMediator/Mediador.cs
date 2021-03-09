using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoMediator
{
    public abstract class Mediador
    {
        public abstract void Enviar(string mensagem, Jogador jogador);
    }
}
