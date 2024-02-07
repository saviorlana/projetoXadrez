using System.Xml;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;


namespace xadrez_console
{ 
    internal class Program // Associação (composição) de referencias no codigo abaixo
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);


            Console.WriteLine(pos.ToPosicao());

            Console.WriteLine();
        }
    }
}
