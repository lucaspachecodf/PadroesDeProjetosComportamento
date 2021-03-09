using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoIterator
{
    public interface IIterator
    {
        string primeiroItem { get; }
        string proximoItem { get; }
        string atualItem { get; }
        bool estaPronto { get; }
    }
}
