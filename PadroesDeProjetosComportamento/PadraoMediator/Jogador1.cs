using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjetosComportamento.PadraoMediator
{
    public class Jogador1 : Jogador
    {
        public Jogador1(Mediador mediador) : base(mediador) { }
        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem, this);
        }
        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do Jogador 1: " + mensagem);
        }
    }
}
