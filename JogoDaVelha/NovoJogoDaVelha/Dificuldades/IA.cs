using JogoDaVelha.Dificuldades.Interface;


namespace JogoDaVelha.Dificuldades
{
    public class IA : IAnalisar
    {
        public int SelectedNumber { get; set; }
        public void PlayerIA(int[] posicoesVitoria, List<int> posicoesDoJogo, string dificuldade = "")
        {

            Random random = new Random();
            var posicoesRestantes = posicoesVitoria.Except(posicoesDoJogo);
            var a = posicoesRestantes.ToList();
            var randomIndex = random.Next(posicoesRestantes.ToList().Count);

            SelectedNumber = posicoesRestantes.ToArray()[randomIndex];

                
        }
    }
}
