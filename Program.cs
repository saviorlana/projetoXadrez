using System.Xml;
using System.Collections.Generic;   
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;


namespace xadrez_console {
    internal class Program // Associação (composição) de referencias no codigo abaixo
    {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada) {
                    try {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);
                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    } catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    Console.Clear();
                    Tela.ImprimirPartida(partida);
                }
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
