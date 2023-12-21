using Bunit;
using JogoDaVelha;
using JogoDaVelha.Pages;
using JogoDaVelha.Pages.Modals;
using System.Reflection;

namespace TestGame
{
    public class TestarFuncionalidadesDoGame
    {
        TestContext testContext;
        public TestarFuncionalidadesDoGame()
        {
            testContext = new TestContext();
        }
        [Fact]
        public void TestarInicializacaoDoGame()
        {
            var modalInitGame = new ModalInitGame();

            var component = testContext.RenderComponent<ModalInitGame>();

            Assert.Equal(GlobalConstants.BLOCK, component.Instance.modalDisplay);
        }

        [Theory]
        [InlineData(GlobalConstants.CIRCULO_PNG)]
        [InlineData(GlobalConstants.X_PNG)]
        public void TestarEscolhaDoJogador(string escolhaUsuario)
        {
            var component = testContext.RenderComponent<JogoDaVelha.Pages.Index>();
            
            //component.Instance.InitGame(component.Instance);

            Assert.Equal(escolhaUsuario, component.Instance.game.ChoiceUser);
            Assert.NotEqual(escolhaUsuario, component.Instance.game.DontChoice);

        }

        [Fact]
        public void TestarReset()
        {
            int indice = 8;
            var component = testContext.RenderComponent<JogoDaVelha.Pages.Index>();
            var buttonReset = component.Find("button");
            buttonReset.Click();

            for (int i = 0; i <= indice; i++)
            {
                Assert.Equal(GlobalConstants.NONE, component.Instance.game.DisplayCasa[i]);
            }

        }
    
    }
}
