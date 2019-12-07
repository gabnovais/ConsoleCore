using Gametop.Interface;

namespace Gametop.lib
{
    public class Jogador2 : iJogador
    {
        string iJogador.Chuta()
        {
            return "Maradona está chutando\n";
        }

        string iJogador.Corre()
        {
            return "Maradona está correndo\n";
        }

        string iJogador.Passa()
        {
            return "Maradona está passando\n";
        }
    }
}