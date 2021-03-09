using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoStrategy
{
    public class Sapo : IAjuda
    {
        public string Ajudar(Ajuda pedido)
        {
            return "Sou um sapo e posso ajudar você a pular bem alto!";
        }
    }
}
