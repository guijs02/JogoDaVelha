using JogoDaVelha.Classes;
using Xunit.Sdk;

namespace Test
{
    public class TestarTodasSituacoesDeVitoriaDoGame
    {
        private Game Game { get; set; }
        public TestarTodasSituacoesDeVitoriaDoGame()
        {
            Game = new Game();
        }

      
        [Fact]
        public void VerificarVitoriaHorizontal()
        {
            try
            {
                Horizontal horizontal = new();

                List<List<int>> dadosHorizontal = new()
                {
                    new List<int> { 0, 1, 2 },
                    new List<int> { 3, 4, 5 },
                    new List<int> { 6, 7, 8 }
                };


                foreach (List<int> dados in dadosHorizontal)
                {

                    var resultado = horizontal.Verifica(Game.PosicoesDeVitorias, dados);

                    Assert.True(resultado);
                }
            }
            catch (TrueException ex)
            {
                Console.WriteLine(ex.ToString());

                throw;
            }

        }

        [Fact]
        public void VerificarVitoriaVertical()
        {
            try
            {
                var posicoes = new List<int> { 0, 3, 6 };
                
                Vertical vertical = new();

                List<List<int>> dadosVertical = new()
                {
                    new List<int> { 0, 3, 6 },
                    new List<int> { 1, 4, 7 },
                    new List<int> { 2, 5, 8 }
                };

                foreach (List<int> dados in dadosVertical)
                {

                    var resultado = vertical.Verifica(Game.PosicoesDeVitorias, dados);

                    Assert.True(resultado);
                }
            }
            catch (TrueException ex)
            {
                Console.WriteLine(ex.ToString());

                throw;
            }

        }
        [Fact]
        public void VerificarVitoriaDiagonal()
        {
            try
            {
                var posicoes = new List<int> { 0, 3, 6 };
                Diagonal vertical = new();

                List<List<int>> dadosDiagonal = new()
                {
                    new List<int> { 0, 4, 8 },
                    new List<int> { 2, 4, 6 },
                };

                foreach (List<int> dados in dadosDiagonal)
                {

                    var resultado = vertical.Verifica(Game.PosicoesDeVitorias, dados);

                    Assert.True(resultado);
                }
            }
            catch (TrueException ex)
            {
                Console.WriteLine(ex.ToString());

                throw;
            }

        }
    }
}