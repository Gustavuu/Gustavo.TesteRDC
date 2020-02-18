using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gustavo.TesteRDC.Tests
{
    [TestClass]
    public class ExercicioSinaisTests
    {
        ExercicioSinais sinais = new ExercicioSinais();
        [TestMethod]
        public void ParesCombinados_true1()
        {
            Assert.IsTrue(sinais.ParesCombinados("{[()]}"));
        }

        [TestMethod]
        public void ParesCombinados_false1()
        {
            Assert.IsFalse(sinais.ParesCombinados("{[(])}"));
        }

        [TestMethod]
        public void ParesCombinados_true2()
        {
            Assert.IsTrue(sinais.ParesCombinados("{{[[(())]]}}"));
        }

        [TestMethod]
        public void ParesCombinados_false2()
        {
            var sinais = new ExercicioSinais();
            Assert.IsFalse(sinais.ParesCombinados("{{[[(())}}}}"));
        }

        [TestMethod]
        public void ParesCombinados_true3()
        {
            Assert.IsTrue(sinais.ParesCombinados("{[{[[([])]]}]}"));
        }

        [TestMethod]
        public void ParesCombinados_false3()
        {
            var sinais = new ExercicioSinais();
            Assert.IsFalse(sinais.ParesCombinados("{[(([([])]]}]}"));
        }
    }
}
