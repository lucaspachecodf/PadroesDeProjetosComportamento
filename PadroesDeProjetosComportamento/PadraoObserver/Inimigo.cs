using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoObserver
{
    public class Inimigo : IObservador
    {
        private Cody personagemObservado;

        public Inimigo(Cody cody)
        {
            personagemObservado = cody;
            personagemObservado.RegistrarObservador(this);
        }

        public void Avisar(IPersonagem personagem)
        {
            if (personagem == personagemObservado)
            {
                Console.WriteLine("O Cody foi acertado com um golpe, agora sua vida de jogo é de: " + personagemObservado.getVida());
            }
        }
    }
}
