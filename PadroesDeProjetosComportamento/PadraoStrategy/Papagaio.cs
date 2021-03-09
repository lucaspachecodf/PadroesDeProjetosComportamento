using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoStrategy
{
    public class Papagaio : IAjuda
    {
        public string Ajudar(Ajuda pedido)
        {
            return "Sou um Papagaio e posso ajudar você a voar!";
        }
    }
}
