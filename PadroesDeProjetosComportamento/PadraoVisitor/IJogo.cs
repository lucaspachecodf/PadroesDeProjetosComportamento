using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoVisitor
{
    public interface IJogo
    {
        void Visitante(IVisitor visitor);
    }
}
