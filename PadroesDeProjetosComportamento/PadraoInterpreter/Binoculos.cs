﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoInterpreter
{
    public class Binoculos : IFerramenta
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Binóculos ");
        }
    }
}
