using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoTemplateMethod
{
    public class ModoNormal : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("O carro precisa abastecer uma vez");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Os carros devem correr na mesma velocidade");
        }
    }
}
