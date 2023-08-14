namespace JogoDaVelha.Classes
{
    public class Game
    {
        public string[] IconGame = new string[9];
        public string ChoiceUser { get; set; } = string.Empty;
        public string DontChoice { get; set; } = string.Empty;

        public string[] DisplayCasa = new string[9];

        public List<(int posicao, string icon)> PosicoesEscolhidas = new();

        public List<(int posicao, string icon)> PosicoesNaoEscolhidas = new();

        public readonly int[] PosicoesDeVitorias = new int[]
        {
             //horizontal
             0,1,2,
             3,4,5,
             6,7,8,
             //vertical
             0,3,6,
             1,4,7,
             2,5,8,
             //diagonal
             0,4,8,
             2,4,6
        };


    }
}
