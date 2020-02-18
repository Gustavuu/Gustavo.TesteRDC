using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gustavo.TesteRDC.Tests
{
    [TestClass]
    public class ExercicioSalveRianTests
    {
        ExercicioSalveRian exercicio = new ExercicioSalveRian();

        [TestMethod]
        public void Posicao3_Soldados5_true()
        {
            int posicaoSobrevivencia = exercicio.SalveRian(5);
            Assert.AreEqual(3, posicaoSobrevivencia);
        }

        [TestMethod]
        public void Posicao5_Soldados10_true()
        {
            int posicaoSobrevivencia = exercicio.SalveRian(10);
            Assert.AreEqual(5, posicaoSobrevivencia);
        }

        [TestMethod]
        public void Posicao19_Soldados41_true()
        {
            int posicaoSobrevivencia = exercicio.SalveRian(41);
            Assert.AreEqual(19, posicaoSobrevivencia);
        }

        [TestMethod]
        public void Posicao4_Soldados5_false()
        {
            int posicaoSobrevivencia = exercicio.SalveRian(5);
            Assert.AreNotEqual(4, posicaoSobrevivencia);
        }

        [TestMethod]
        public void Posicao7_Soldados10_false()
        {
            int posicaoSobrevivencia = exercicio.SalveRian(10);
            Assert.AreNotEqual(7, posicaoSobrevivencia);
        }

        [TestMethod]
        public void Posicao20_Soldados41_false()
        {
            int posicaoSobrevivencia = exercicio.SalveRian(41);
            Assert.AreNotEqual(20, posicaoSobrevivencia);
        }
    }
}
