using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoObserver
{
    public interface IPersonagem
    {
        void RegistrarObservador(IObservador observador);
        void NotificarPersonagens();
    }
}
