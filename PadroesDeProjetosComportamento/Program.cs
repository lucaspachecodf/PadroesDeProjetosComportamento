using PadroesDeProjetosComportamento.PadraoChainOfResponsability;
using PadroesDeProjetosComportamento.PadraoCommand;
using PadroesDeProjetosComportamento.PadraoInterpreter;
using PadroesDeProjetosComportamento.PadraoIterator;
using PadroesDeProjetosComportamento.PadraoMediator;
using PadroesDeProjetosComportamento.PadraoMemento;
using PadroesDeProjetosComportamento.PadraoObserver;
using PadroesDeProjetosComportamento.PadraoStrategy;
using PadroesDeProjetosComportamento.PadraoTemplateMethod;
using PadroesDeProjetosComportamento.PadraoVisitor;
using System;
using System.Collections.Generic;

namespace PadroesDeProjetosComportamento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Padrão Template Method

            //Console.WriteLine("### Escolha o modo de corrida ###");
            //Console.WriteLine("1-Fácil | 2-Normal | 3-Difícil");
            //Console.WriteLine("Suas condições de jogo são: ");
            //Jogo jogo = null;

            //switch (Console.ReadLine())
            //{
            //    case "1": jogo = new ModoFacil(); break;
            //    case "2": jogo = new ModoNormal(); break;
            //    case "3": jogo = new ModoDificil(); break;
            //}
            //Console.ReadKey();

            #endregion

            #region Padrão Interpreter

            //Mochila mochila = new Mochila(new Corda(), new Binoculos(), new ArcoFlecha());
            //mochila.Interpretar(new Contexto());
            //Console.ReadKey();

            #endregion

            #region Padrão Observer

            //Cody cody = new Cody();
            //Inimigo inimigo1 = new Inimigo(cody);
            //Inimigo inimigo2 = new Inimigo(cody);
            //Inimigo inimigo3 = new Inimigo(cody);

            //while (true)
            //{
            //    Console.WriteLine("Acertar o Cody com um golpe (S ou N) ? ");
            //    if (Console.ReadLine() == "s")
            //        cody.Golpe_Acertado(true);
            //    else
            //        Console.WriteLine("Você não acertou o Cody!");
            //}

            #endregion

            #region Padrão Visitor

            //List<IJogo> jogo = new List<IJogo>();
            //jogo.Add(new FaseJogo() { NomeFase = "Floresta" });
            //jogo.Add(new FaseJogo() { NomeFase = "Caverna" });
            //jogo.Add(new Chefao()
            //{
            //    NomeChefao = "Boss 1",
            //    PontosVida = 30
            //});

            //jogo.Add(new Chefao()
            //{
            //    NomeChefao = "Boss 2",
            //    PontosVida = 50
            //});

            //NivelVisitor niveis = new NivelVisitor();
            //foreach (var etapa in jogo)
            //{
            //    etapa.Visitante(niveis);
            //}
            //Console.ReadLine();

            #endregion

            #region Padrão Command

            //Controle controle = new Controle();
            //controle.EnviarComandoSimples(new SimplesComando("Dizer Oi!"));

            //Receiver receiver = new Receiver();
            //controle.EnviarComandoComplexo(new ComplexoComando(receiver, "Abastecer o carro", "Calibrar os pneus do carro"));
            //controle.Fazer();
            //Console.ReadKey();

            #endregion

            #region Padrão Strategy

            //var papagaio = new Ajuda(new Papagaio());
            //Console.WriteLine(papagaio.Ajudar());
            //var sapo = new Ajuda(new Sapo());
            //Console.WriteLine(sapo.Ajudar());
            //Console.ReadKey();

            #endregion

            #region Padrão Chain Of Responsability

            //Manipulador pA = new PersonagemA();
            //Manipulador pB = new PersonagemB();
            //Manipulador pC = new PersonagemC();
            //pA.defineSucessor(pB);
            //pB.defineSucessor(pC);
            //int[] requisicoes = { 5, 8, 15, 20, 18, 3, 27, 20 };

            //foreach (int req in requisicoes)
            //{
            //    pA.Convoca(req);
            //}
            //Console.ReadKey();

            #endregion

            #region Padrão Iterator

            //Aggregate colecaoDeFases = new Aggregate();
            //colecaoDeFases[0] = "Fase 1";
            //colecaoDeFases[1] = "Fase 2";
            //colecaoDeFases[2] = "Fase 3";
            //colecaoDeFases[3] = "Fase 4";
            //colecaoDeFases[4] = "Fase 5";

            //IIterator itterator = colecaoDeFases.GetIterator();

            //for (string s = itterator.primeiroItem; itterator.estaPronto == false; s = itterator.proximoItem)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.ReadKey();

            #endregion

            #region Padrão Mediator

            //MediadorConcreto mediador = new MediadorConcreto();
            //Jogador1 j1 = new Jogador1(mediador);
            //Jogador2 j2 = new Jogador2(mediador);
            //mediador.Jogador1 = j1;
            //mediador.Jogador2 = j2;
            //j1.Enviar("Essa partida foi muito boa!");
            //j2.Enviar("Foi sensacional. Conseguimos uma ótima pontuação!");

            //Console.ReadKey();

            #endregion

            #region Padrão Memento

            //Acao acao = new Acao();
            //acao.Estado = "play";
            //Armazena armazena = new Armazena();
            //armazena.Memento = acao.CriarMemento();
            //acao.Estado = "pause";
            //acao.RestaurarEstado(armazena.Memento);
            //Console.ReadKey();

            #endregion

            #region Padrão State

            PadraoState.Contexto contexto = new PadraoState.Contexto(new PadraoState.PersonagemA());
            contexto.Troca();
            contexto.Troca();
            contexto.Troca();
            contexto.Troca();
            Console.ReadKey();

            #endregion
        }
    }
}
