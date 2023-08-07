using JogoDaVelha.Classes.Interface;

namespace JogoDaVelha.Classes
{
    public class Horizontal : TipoVitoria
    {
        public Horizontal(TipoVitoria vitoria) : base(vitoria) { }
        public Horizontal() : base() { }

        public override bool Verifica(int[] PosicoesDeVitorias, List<int> PosicoesDoJogo)
        {
            if ((PosicoesDoJogo.Contains(PosicoesDeVitorias[0]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[1]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[2])) ||
               (PosicoesDoJogo.Contains(PosicoesDeVitorias[3]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[4]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[5])) ||
               (PosicoesDoJogo.Contains(PosicoesDeVitorias[6]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[7]) && PosicoesDoJogo.Contains(PosicoesDeVitorias[8])))
            {
                return true;
            }
            return VerificaOutroTipoDeVitoria(PosicoesDeVitorias, PosicoesDoJogo); 

        }

    }
}
