using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoIterator
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int indexItem] { set; get; }
        int Contador { get; }
    }
}
