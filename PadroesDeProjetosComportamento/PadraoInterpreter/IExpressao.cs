using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoInterpreter
{
    public interface IExpressao
    {
        void Interpretar(Contexto contexto);
    }
}
