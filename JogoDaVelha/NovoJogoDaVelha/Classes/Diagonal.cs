using JogoDaVelha.Classes.Interface;

namespace JogoDaVelha.Classes
{
    public class Diagonal : TipoVitoria
    {
        public Diagonal(TipoVitoria vitoria) : base(vitoria) { }
        public Diagonal() : base() { }
        
        public override bool Verifica(int[] PosicoesDeVitorias, List<int> PosicoesDoJogo)
        {
            if (PosicoesDoJogo.Contains(PosicoesDeVitorias[0]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[4]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[8]) ||
                   PosicoesDoJogo.Contains(PosicoesDeVitorias[2]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[4]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[6]))
            {
                return true;
            }
            return VerificaOutroTipoDeVitoria(PosicoesDeVitorias, PosicoesDoJogo);

        }
    }
}
