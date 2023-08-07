using JogoDaVelha.Classes.Interface;

namespace JogoDaVelha.Classes
{
    public class VerificadorDeVitoria
    {
        public Diagonal diagonal { get; private set; }
        public VerificadorDeVitoria()
        {
            diagonal = new(new Horizontal(new Vertical()));
        }
        public bool AnalisarGanhador(int[] PosicoesDeVitoria, List<int> PosicoesDoJogo)
        {
            bool vitoria = diagonal.Verifica(PosicoesDeVitoria, PosicoesDoJogo);
       
            return vitoria;
        }
    }
}
