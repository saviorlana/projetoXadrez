using System.Xml;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;


namespace xadrez_console
{ 
    internal class Program // Associação (composição) de referencias no codigo abaixo
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));

                Tela.ImprimirTabuleiro(tab);
                Console.WriteLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
