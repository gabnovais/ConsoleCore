using System;
using Gametop.lib;

namespace Gametop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador2(), 
                new Jogador1());

            jogo.IniciarJogo();
        }
 
    }
}
