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
    
    }
}
