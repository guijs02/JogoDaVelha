using JogoDaVelha.Classes;
using Microsoft.AspNetCore.Components;

namespace JogoDaVelha.Dificuldades
{
    public class GerenciadorDeDificuldades
    {
        public Facil Facil { get; set; }
        public Game game { get; set; }
        public GerenciadorDeDificuldades()
        {
            Facil = new();
            game = new Game();
        }
        public void VerificarDificuldades(string dificuldade)
        {
            //Facil.VerificarDificuldadeDaIA(game.PosicoesDeVitorias,dificuldade);
        }
    }
}
