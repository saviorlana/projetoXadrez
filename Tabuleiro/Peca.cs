using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro {
    internal class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
        public void IncrementarQteMovimentos() {
            QteMovimentos++;
        }
    }
}
