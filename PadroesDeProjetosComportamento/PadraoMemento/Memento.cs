using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoMemento
{
    public class Memento
    {
        private string _estado;

        public Memento(string estado)
        {
            this._estado = estado;
        }

        public string Estado
        {
            get { return _estado; }
        }
    }
}
