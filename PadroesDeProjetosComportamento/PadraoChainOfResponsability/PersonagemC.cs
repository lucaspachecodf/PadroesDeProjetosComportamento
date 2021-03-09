using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoChainOfResponsability
{
    public class PersonagemC : Manipulador
    {
        public override void Convoca(int quantidadePoder)
        {
            if (quantidadePoder >= 20 && quantidadePoder < 30)
                Console.WriteLine($"{this.GetType().Name} convocado para uma força de poder de {quantidadePoder}");
            else if (sucessor != null)
                sucessor.Convoca(quantidadePoder);
        }
    }
}
