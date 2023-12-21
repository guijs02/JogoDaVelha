using JogoDaVelha.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace TestGame
{
    public class TesteFalhasDeVitorias
    {
        Game Game { get; set; }
        public TesteFalhasDeVitorias()
        {
            Game = new Game();
        }

        [Fact]
        public void TesteDeFalhaNaVitoriaHorizontal()
        {
            try
            {
                Horizontal horizontal = new();

                List<List<int>> dadosHorizontal = new()
                {
                    new List<int> { 7, 3, 2 },
                    new List<int> { 2, 6, 4 },
                    new List<int> { 8, 2, 4 }
                };

                foreach (List<int> dados in dadosHorizontal)
                {
                    var resultado = horizontal.Verifica(Game.PosicoesDeVitorias, dados);

                    Assert.False(resultado);
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }  
        [Fact]
        public void TesteDeFalhaNaVitoriaDiagonal()
        {
            try
            {
                Diagonal vertical = new();

                List<List<int>> dadosDiagonal = new()
                {
                    new List<int> { 1, 3, 7 },
                    new List<int> { 8, 4, 2 },
                };

                foreach (List<int> dados in dadosDiagonal)
                {

                    var resultado = vertical.Verifica(Game.PosicoesDeVitorias, dados);

                    Assert.False(resultado);
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }

        [Fact]
        public void TesteDeFalhaNaVitoriaVertical()
        {
            try
            {
                var posicoes = new List<int> { 0, 3, 6 };

                Vertical vertical = new();

                List<List<int>> dadosVertical = new()
                {
                    new List<int> { 1, 4, 5 },
                    new List<int> { 2, 8, 6 },
                    new List<int> { 3, 6,7 }
                };

                foreach (List<int> dados in dadosVertical)
                {

                    var resultado = vertical.Verifica(Game.PosicoesDeVitorias, dados);

                    Assert.False(resultado);
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
