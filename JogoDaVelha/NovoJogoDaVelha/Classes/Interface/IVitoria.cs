namespace JogoDaVelha.Classes.Interface
{
    public abstract class TipoVitoria
    {
        public TipoVitoria? ProximaVerificacao { get; private set; }
        public TipoVitoria(TipoVitoria proxVerificacao)
        {
            ProximaVerificacao = proxVerificacao;
        }
        public TipoVitoria()
        {
            ProximaVerificacao = null;
        }

        public abstract bool Verifica(int[] PosicoesDeVitoria, List<int> PosicoesDoJogo);

        public bool VerificaOutroTipoDeVitoria(int[] PosicoesDeVitoria, List<int> PosicoesDoJogo)
        {
            if (ProximaVerificacao is null) return false;
            return ProximaVerificacao.Verifica(PosicoesDeVitoria, PosicoesDoJogo);

        }

    }
}
